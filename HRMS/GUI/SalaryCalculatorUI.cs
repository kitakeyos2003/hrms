using HRMS.BUS.Helper;
using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class SalaryCalculatorUI : Form, IPage
    {
        private Panel panel;
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = ApplicationConfig.MAX_PAGE[0];
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position;
        public SalaryCalculatorUI(Panel panel)
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

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddSalaryUI addSalaryUI = new AddSalaryUI(this);
            addSalaryUI.ShowDialog();
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
                listSalary.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listSalary.Rows)
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
                listSalary.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listSalary.Rows.Add(row);
                }
            }
        }

        private void txtKeyword__TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }

        public void InitPage()
        {
            lbPage.Text = page.ToString();
            List<Salary> salarys = DataManager.GetInstance().Salarys.FindAll(salary => IsMatch(salary));
            int maxPage = PageHelper.TotalPages(salarys.Count, limit);
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

            int[] array = PageHelper.GetStartIndexAndLength(page, limit, salarys.Count);
            int startIndex = array[0];
            int length = array[1]; length = salarys.Count - startIndex;

            List<Salary> list = salarys.GetRange(startIndex, length);
            FillDataGridView(list);

        }

        private bool IsMatch(Salary salary)
        {
            return (department == null || department.Id == salary.Employee.Department.Id) && (position == null || position.Id == salary.Employee.Position.Id);
        }

        private void FillDataGridView(List<Salary> salarys)
        {
            listSalary.Rows.Clear();
            foreach (Salary salary in salarys)
            {
                AddSalary(salary);
            }
        }

        public void AddSalary(Salary salary)
        {
            if (IsMatch(salary))
            {
                if (listSalary.Rows.Count < limit)
                {
                    listSalary.Rows.Add(salary.SalaryID, salary.Employee.FullName, salary.WorkingDays, salary.Allowance, salary.Allowance, salary.Bonus, salary.GrossSalary, salary.Tax, salary.NetSalary, "", salary.PaymentMethod);
                }
                else
                {
                    NextPage();
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

        private void listSalary_SelectionChanged(object sender, EventArgs e)
        {
            if (listSalary.SelectedRows.Count > 0)
            {
                SelectedRow = listSalary.SelectedRows[0];
            }
            else
            {
                SelectedRow = null;
            }
        }

        public void NextPage()
        {
            List<Salary> salarys = DataManager.GetInstance().Salarys.FindAll(salary => IsMatch(salary));
            int maxPage = PageHelper.TotalPages(salarys.Count, limit);
            page++;
            if (page > maxPage)
            {
                page = maxPage;
            }
            InitPage();
        }

        private void prePage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Texts = string.Empty;
            DataManager.GetInstance().LoadAllSalary();
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

        public void PreviousPage()
        {
            page--;
            if (page < 1)
            {
                page = 1;
            }
            InitPage();
        }
    }
}
