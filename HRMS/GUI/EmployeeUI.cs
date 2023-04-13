using HRMS.DAL;
using HRMS.GUI.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EmployeeUI : Form
    {
        private Panel panel;
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position;

        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = ApplicationConfig.MAX_PAGE[0];
        public EmployeeUI(Panel panel)
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
            List<Employee> employees = DataManager.GetInstance().Employees.FindAll(em => IsMatch(em));
            int maxPage = employees.Count / limit;
            if (employees.Count % limit != 0)
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
            if (startIndex + length > employees.Count)
            {
                length = employees.Count - startIndex;
            }

            List<Employee> list = employees.GetRange(startIndex, length);
            FillDataGridView(list);

        }

        private void FillDataGridView(List<Employee> employees)
        {
            listEmployee.Rows.Clear();
            foreach (Employee employee in employees)
            {
                AddEmployee(employee);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Texts = string.Empty;
            DataManager.GetInstance().LoadAllEmployee();
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
                listEmployee.ClearSelection();
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in listEmployee.Rows)
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
                listEmployee.Rows.Clear();
                foreach (DataGridViewRow row in list)
                {
                    listEmployee.Rows.Add(row);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                int employeeID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                Employee employee = DataManager.GetInstance().Employees.SingleOrDefault(em => em.EmployeeID == employeeID);
                if (employee != null)
                {
                    UpdateEmployeeUI updateEmployeeUI = new UpdateEmployeeUI(SelectedRow, employee);
                    updateEmployeeUI.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                try
                {
                    int eID = int.Parse(SelectedRow.Cells[0].Value.ToString());
                    Employee employee = DataManager.GetInstance().Employees.SingleOrDefault(e2 => e2.EmployeeID == eID);
                    if (employee != null)
                    {
                        bool r = DataManager.GetInstance().EmployeeService.Delete(employee.EmployeeID);
                        if (r)
                        {
                            DataManager.GetInstance().Employees.Remove(employee);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeUI addEmployeeUI = new AddEmployeeUI(this);
            addEmployeeUI.ShowDialog();
        }

        internal void AddEmployee(Employee employee)
        {
            if (IsMatch(employee))
            {
                if (listEmployee.Rows.Count < limit)
                {
                    listEmployee.Rows.Add(employee.EmployeeID, employee.FullName, employee.DateOfBirth.ToString("dd/MM/yyyy"), employee.Gender, employee.PhoneNumber, employee.Email, employee.Address, employee.Department.Name, employee.Position.Name, employee.StartDate.ToString("dd/MM/yyyy"), employee.EndDate.ToString("dd/MM/yyyy"), employee.Status == 0 ? "Đang làm việc" : "Đã nghỉ việc");
                }
                else
                {
                    NextPage();
                }
            }
        }

        private void listEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (listEmployee.SelectedRows.Count > 0)
            {
                SelectedRow = listEmployee.SelectedRows[0];
            }
            else
            {
                SelectedRow = null;
            }
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
            List<Employee> employees = DataManager.GetInstance().Employees.FindAll(em => IsMatch(em));
            int maxPage = employees.Count / limit;
            if (employees.Count % limit != 0)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var list = DataManager.GetInstance().Employees.FindAll(em => IsMatch(em)).Select(em => new
            {
                EmployeeID = em.EmployeeID,
                EmployeeName = em.FullName,
                Department = em.Department.Name,
                Position = em.Position.Name,
                DateOfBirth = em.DateOfBirth,
                Gender = em.Gender,
                PhoneNumber = em.PhoneNumber,
                Address = em.Address,
            }).ToList();
            EmployeeReport report = new EmployeeReport();
            report.SetDataSource(list);
            CrystalReport fReport = new CrystalReport();
            fReport.Text = "In danh sách nhân viên";
            fReport.crystalReportViewer.ReportSource = report;
            fReport.ShowDialog();
        }

        private void cbLimitPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLimitPage.SelectedIndex >= 0)
            {

                limit = ApplicationConfig.MAX_PAGE[cbLimitPage.SelectedIndex];
                InitPage();
            }
        }

        private bool IsMatch(Employee employee)
        {
            return (department == null || department.Id == employee.Department.Id) && (position == null || position.Id == employee.Position.Id);
        }
    }
}
