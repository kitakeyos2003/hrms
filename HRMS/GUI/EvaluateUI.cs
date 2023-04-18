using HRMS.BUS.Helper;
using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EvaluateUI : Form, IPage
    {
        private Panel panel;
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = ApplicationConfig.MAX_PAGE[0];
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position;

        public EvaluateUI(Panel panel)
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
            List<Evaluate> evaluates = DataManager.GetInstance().Evaluations.FindAll(evaluate => IsMatch(evaluate));
            int maxPage = PageHelper.TotalPages(evaluates.Count, limit);
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

            int[] array = PageHelper.GetStartIndexAndLength(page, limit, evaluates.Count);
            int startIndex = array[0];
            int length = array[1]; length = evaluates.Count - startIndex;

            List<Evaluate> list = evaluates.GetRange(startIndex, length);
            FillDataGridView(list);

        }

        private void FillDataGridView(List<Evaluate> employees)
        {
            listEvaluate.Rows.Clear();
            foreach (Evaluate evaluate in employees)
            {
                AddEvaluate(evaluate);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddEvaluateUI addEvaluateUI = new AddEvaluateUI(this);
            addEvaluateUI.ShowDialog();
        }

        private void prePage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
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
            List<Evaluate> employees = DataManager.GetInstance().Evaluations.FindAll(evaluate => IsMatch(evaluate));
            int maxPage = PageHelper.TotalPages(employees.Count, limit);
            page++;
            if (page > maxPage)
            {
                page = maxPage;
            }
            InitPage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                try
                {
                    int eID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                    Evaluate evaluate = DataManager.GetInstance().Evaluations.SingleOrDefault(e2 => e2.EvaluateID == eID);
                    if (evaluate != null)
                    {
                        bool r = DataManager.GetInstance().EvaluationService.Delete(evaluate.EvaluateID);
                        if (r)
                        {
                            DataManager.GetInstance().Evaluations.Remove(evaluate);
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

        private void listEvaluate_SelectionChanged(object sender, EventArgs e)
        {
            if (listEvaluate.SelectedRows.Count > 0)
            {
                SelectedRow = listEvaluate.SelectedRows[0];
            }
            else
            {
                SelectedRow = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                int eID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                Evaluate evaluate = DataManager.GetInstance().Evaluations.SingleOrDefault(em => em.EvaluateID == eID);
                if (evaluate != null)
                {
                    UpdateEvaluateUI updateEvaluate = new UpdateEvaluateUI(SelectedRow, evaluate);
                    updateEvaluate.ShowDialog();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Texts = string.Empty;
            DataManager.GetInstance().LoadAllEvaluate();
            InitPage();
            Alert alert = new Alert();
            alert.ShowAlert("Làm mới thành công!", Alert.EnumType.SUCCESS);
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex > 0)
            {
                department = Departments[cbDepartment.SelectedIndex - 1];
            }
            else
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

        public void AddEvaluate(Evaluate evaluate)
        {
            if (IsMatch(evaluate))
            {
                if (listEvaluate.Rows.Count < limit)
                {
                    listEvaluate.Rows.Add(evaluate.EvaluateID, evaluate.Employee.FullName, evaluate.Employee.Department.Name, evaluate.EvaluationPeriod.ToString("dd/MM/yyyy"), evaluate.EvaluationCriteria, evaluate.EvaluationScore, evaluate.ManagerComment, evaluate.EmployeeComment, evaluate.EvaluationResult, evaluate.ImprovementPlan);
                }
                else
                {
                    NextPage();
                }
            }
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
                listEvaluate.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listEvaluate.Rows)
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
                listEvaluate.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listEvaluate.Rows.Add(row);
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

        private void txtKeyword__TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }

        private bool IsMatch(Evaluate evaluate)
        {
            return (department == null || department.Id == evaluate.Employee.Department.Id) && (position == null || position.Id == evaluate.Employee.Position.Id);
        }
    }
}
