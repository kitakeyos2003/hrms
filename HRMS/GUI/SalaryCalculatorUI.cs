using HRMS.BUS.Helper;
using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class SalaryCalculatorUI : Form, IPage
    {
        private Panel panel;
        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, pageSize = ApplicationConfig.MAX_PAGE[0];
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position;
        BindingSource source;
        string searchText;
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
            source = new BindingSource();
            source.RaiseListChangedEvents = true;
            source.AllowNew = false;
            listSalary.DataSource = source;


            foreach (int limit in ApplicationConfig.MAX_PAGE)
            {
                cbLimitPage.Items.Add(limit);
            }
            cbLimitPage.SelectedIndex = 0;
            pageSize = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];

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
            if (string.IsNullOrEmpty(searchText))
            {
                this.searchText = null;
            }
            else
            {
                this.searchText = searchText;
            }
            InitPage();

        }

        private void txtKeyword__TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            Search(keyword);
        }

        public void InitPage()
        {
            List<Salary> salarys = GetList();
            int maxPage = PageHelper.TotalPages(salarys.Count, pageSize);
            if (page <= 1)
            {
                page = 1;
                prePage.Enabled = false;
            }
            else
            {
                prePage.Enabled = true;
            }
            if (page >= maxPage)
            {
                page = maxPage;
                nextPage.Enabled = false;
            }
            else
            {
                nextPage.Enabled = true;
            }
            lbPage.Text = page.ToString();
            List<Salary> newList = salarys.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            source.DataSource = newList;
            listSalary.Columns["SalaryID"].HeaderText = "Mã lương";
            listSalary.Columns["Employee"].HeaderText = "Họ và tên";
            listSalary.Columns["WorkingDays"].HeaderText = "Ngày công";
            listSalary.Columns["GrossSalary"].HeaderText = "Tổng thu nhập";
            listSalary.Columns["BasicSalary"].HeaderText = "Lương";
            listSalary.Columns["BasicSalary"].HeaderText = "Lương";
            listSalary.Columns["BasicSalary"].HeaderText = "Lương";
        }

        private List<Salary> GetList()
        {
            List<Salary> salarys = DataManager.GetInstance().Salarys.FindAll(e => IsMatch(e));
            return salarys;
        }

        private bool IsMatch(Salary salary)
        {
            return (department == null || department.Id == salary.Employee.Department.Id) && (position == null || position.Id == salary.Employee.Position.Id) && (searchText == null || salary.Employee.FullName.Contains(searchText));
        }

        public void AddSalary(Salary salary)
        {
            source.Add(salary);
            List<Salary> salarys = GetList();
            int maxPage = PageHelper.TotalPages(salarys.Count, pageSize);
            if (maxPage > page)
            {
                page = maxPage;
                InitPage();
            }
        }



        private void cbLimitPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLimitPage.SelectedIndex >= 0)
            {

                pageSize = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];
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
            List<Salary> salarys = GetList();
            int maxPage = PageHelper.TotalPages(salarys.Count, pageSize);
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

        private void listSalary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = listSalary.Columns[e.ColumnIndex];
            if (column.Name == "Employee")
            {
                Employee employee = (Employee)e.Value;
                e.Value = employee.FullName;
            }
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
