using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class CandidateUI : Form
    {
        private Panel panel;
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = ApplicationConfig.MAX_PAGE[0];

        List<Department> Departments;
        List<Position> Positions;
        Department department; 
        Position position;
        public CandidateUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            Init();
            InitPage();
        }

        public void Init()
        {
            foreach (int limit in ApplicationConfig.MAX_PAGE)
            {
                cbLimitPage.Items.Add(limit);
            }
            cbLimitPage.SelectedIndex = 0;
            limit = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];

            cbDepartment.Items.Clear();
            Departments = DataManager.GetInstance().Departments;
            cbDepartment.Items.Add("Tất cả");
            if (Departments.Count > 0)
            {
                for (int i = 0; i < Departments.Count; i++)
                {
                    Department department = Departments[i];
                    cbDepartment.Items.Add(department.Name);
                }
            }
            cbDepartment.SelectedIndex = 0;

            cbPosition.Items.Clear();
            Positions = DataManager.GetInstance().Positions;
            cbPosition.Items.Add("Tất cả");
            if (Positions.Count > 0)
            {
                for (int i = 0; i < Positions.Count; i++)
                {
                    Position position = Positions[i];
                    cbPosition.Items.Add(position.Name);
                }
            }
            cbPosition.SelectedIndex = 0;
        }

        public void InitPage()
        {

            lbPage.Text = page.ToString();
            List<Candidate> candidates = DataManager.GetInstance().Candidates.FindAll(c => IsMatch(c));
            int maxPage = candidates.Count / limit;
            if (candidates.Count % limit != 0)
            {
                maxPage += 1;
            }
            if (page <= 1)
            {
                prePage.Enabled = false;
            }
            else
            {
                prePage.Enabled = true;
            }
            if (page >= maxPage)
            {
                nextPage.Enabled = false;
            }
            else
            {
                nextPage.Enabled = true;
            }

            int startIndex = (page - 1) * limit;
            int length = limit;
            if (startIndex + length > candidates.Count)
            {
                length = candidates.Count - startIndex;
            }
            List<Candidate> list = candidates.GetRange(startIndex, length);
            FillDataGridView(list);
        }

        private void FillDataGridView(List<Candidate> candidates)
        {
            listCandidate.Rows.Clear();
            foreach (Candidate candidate in candidates)
            {
                AddCandidate(candidate);
            }
        }

        public string GetInterviewResult(int index)
        {
            if (index == 1)
            {
                return "Đạt";
            }
            else if (index == 2)
            {
                return "Trượt";
            }
            return "Đang xét duyệt";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCandidateUI addCandidateUI = new AddCandidateUI(this);
            addCandidateUI.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                int candidateID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                Candidate candidate = DataManager.GetInstance().Candidates.SingleOrDefault(em => em.CandidateID == candidateID);
                if (candidate != null)
                {
                    UpdateCandidateUI updateCandidateUI = new UpdateCandidateUI(SelectedRow, candidate);
                    updateCandidateUI.ShowDialog();
                }
            }

        }

        internal void AddCandidate(Candidate candidate)
        {
            if (IsMatch(candidate))
            {
                if (listCandidate.Rows.Count < limit)
                {
                    listCandidate.Rows.Add(candidate.CandidateID,
                        candidate.FullName,
                        candidate.PositionApplied.Name,
                        candidate.DepartmentApplied.Name,
                        candidate.ContactInformation,
                        candidate.Education,
                        candidate.WorkExperience,
                        candidate.Skills,
                        candidate.InterviewDate,
                        candidate.Interviewer,
                        GetInterviewResult(candidate.InterviewResult));
                }
                else
                {
                    NextPage();
                }
            }
        }

        private void listCandidate_SelectionChanged(object sender, EventArgs e)
        {
            if (listCandidate.SelectedRows.Count > 0)
            {
                SelectedRow = listCandidate.SelectedRows[0];
            }
            else
            {
                SelectedRow = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                try
                {

                    int eID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                    Candidate candidate = DataManager.GetInstance().Candidates.SingleOrDefault(e2 => e2.CandidateID == eID);
                    if (candidate != null)
                    {
                        bool r = DataManager.GetInstance().CandidateService.Delete(candidate.CandidateID);
                        if (r)
                        {
                            DataManager.GetInstance().Candidates.Remove(candidate);
                            InitPage();
                            SelectedRow = null;
                        }
                    }
                }
                catch
                {
                    Alert alert = new Alert();
                    alert.ShowAlert("Có lỗi xảy ra", Alert.EnumType.ERROR);
                }
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void prePage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        public void PreviousPage()
        {
            page--;
            if (page < 1)
            {
                page = 1;
            }
            InitPage();
        }

        public void NextPage()
        {
            List<Candidate> candidates = DataManager.GetInstance().Candidates.FindAll(c => IsMatch(c)); 
            int maxPage = candidates.Count / limit;
            if (candidates.Count % limit != 0)
            {
                maxPage += 1;
            }
            page++;
            if (page > maxPage)
            {
                page = maxPage;
            }
            InitPage();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex > 0)
            {
                department = Departments[cbDepartment.SelectedIndex - 1];
            } else
            {
                department = null;
            }
            InitPage();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedIndex > 0)
            {
                position = Positions[cbPosition.SelectedIndex - 1];
            }
            else
            {
                position = null;
            }
            InitPage();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Texts = string.Empty;
            DataManager.GetInstance().LoadAllCandidate();
            InitPage();
            Alert alert = new Alert();
            alert.ShowAlert("Làm mới thành công!", Alert.EnumType.SUCCESS);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }
        private void Search(string searchText)
        {
            InitPage();
            if (!string.IsNullOrEmpty(searchText))
            {
                listCandidate.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listCandidate.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower()))
                        {
                            list.Add(row);
                            break;
                        }
                    }
                }
                listCandidate.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listCandidate.Rows.Add(row);
                }
            }
        }

        private void cbLimitPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLimitPage.SelectedIndex >= 0)
            {

                limit = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];
                InitPage();
            }
        }

        private bool IsMatch(Candidate candidate)
        {
            return (department == null || department.Id == candidate.DepartmentApplied.Id) && (position == null || position.Id == candidate.PositionApplied.Id);
        }

    }
}
