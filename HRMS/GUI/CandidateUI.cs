using HRMS.DAL;
using HRMS.DAL.Models;
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
        private int page = 1, limit = 20;
        public CandidateUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitPage();
        }

        public void InitPage()
        {

            lbPage.Text = page.ToString();
            List<Candidate> candidates = DataManager.GetInstance().Candidates;
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
            List<Candidate> candidates = DataManager.GetInstance().Candidates;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataManager.GetInstance().LoadAllCandidate();
            InitPage();
            Alert alert = new Alert();
            alert.ShowAlert("Làm mới thành công!", Alert.EnumType.SUCCESS);
        }

    }
}
