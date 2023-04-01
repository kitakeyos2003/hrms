using HRMS.DAL;
using HRMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EmployeeUI : Form
    {
        private Panel panel;

        public DataGridViewRow SelectedRow { get; private set; }
        private int page = 1, limit = 20;
        public EmployeeUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitPage();
        }

        public void InitPage()
        {
            lbPage.Text = page.ToString();
            List<Employee> employees = DataManager.GetInstance().Employees;
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
            if (startIndex >= employees.Count)
            {
                startIndex = employees.Count - 1;
                length = 1;
            }
            else if (startIndex + length > employees.Count)
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
            var employees = DataManager.GetInstance().Employees;
            listEmployee.Rows.Clear();
            FillDataGridView(employees);
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
            if (!string.IsNullOrEmpty(searchText))
            {
                listEmployee.ClearSelection();
                listEmployee.Rows.Clear();
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
                foreach (DataGridViewRow row in list)
                {
                    listEmployee.Rows.Add(row);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   if (SelectedRow != null)
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
            if (listEmployee.Rows.Count < limit)
            {
                listEmployee.Rows.Add(employee.EmployeeID, employee.FullName, employee.DateOfBirth.ToString("dd/MM/yyyy"), employee.Gender, employee.PhoneNumber, employee.Email, employee.Address, employee.Department.Name, employee.Position.Name, employee.StartDate.ToString("dd/MM/yyyy"), employee.EndDate.ToString("dd/MM/yyyy"), employee.Status == 0 ? "Đang làm việc" : "Đã nghỉ việc");
            }
            else
            {
                if (!nextPage.Enabled)
                {
                    nextPage.Enabled = true;
                }
            }
        }

        private void listEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (listEmployee.SelectedRows.Count > 0)
            {
                SelectedRow = listEmployee.SelectedRows[0];
            } else
            {
                SelectedRow = null;
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

        private void prePage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        public void NextPage()
        {
            List<Employee> employees = DataManager.GetInstance().Employees;
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
    }
}
