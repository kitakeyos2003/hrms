using HRMS.DAL;
using HRMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EmployeeUI : Form, ITab
    {
        private Panel panel;

        public DataGridViewRow SelectedRow { get; private set; }

        public EmployeeUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitDataGridView();
        }

        public void InitDataGridView()
        {
            var employees = DataManager.GetInstance().Employees;
            if (employees != null)
            {
                FillDataGridView(employees);
            }

        }

        public void Open()
        {
            Show();
        }

        private void FillDataGridView(List<Employee> employees)
        {
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
            if (listEmployee.SelectedRows.Count > 0)
            {
                Alert alert = new Alert();
                try
                {

                    foreach (DataGridViewRow row in listEmployee.SelectedRows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            try
                            {
                                int eID = int.Parse(row.Cells[0].Value.ToString());
                                Employee employee = DataManager.GetInstance().Employees.SingleOrDefault(e2 => e2.EmployeeID == eID);
                                if (employee != null)
                                {
                                    listEmployee.Rows.Remove(row);
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                catch
                {
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
            listEmployee.Rows.Add(employee.EmployeeID, employee.FullName, employee.DateOfBirth.ToString("dd/MM/yyyy"), employee.Gender, employee.PhoneNumber, employee.Email, employee.Address, employee.Department.Name, employee.Position.Name, employee.StartDate.ToString("dd/MM/yyyy"), employee.EndDate.ToString("dd/MM/yyyy"), employee.Status == 0 ? "Đang làm việc" : "Đã nghỉ việc");
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
    }
}
