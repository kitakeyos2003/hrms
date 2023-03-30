using HRMS.DAL;
using HRMS.DAL.Models;
using HRMS.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EmployeeUI : Form, ITab
    {
        private Panel panel;
        DataGridViewRow selectRow;
        public EmployeeUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitDataGridView();
        }

        public void InitDataGridView()
        {

            Sex.Items.Add("Nam");
            Sex.Items.Add("Nữ");
            Sex.Items.Add("Không xác định");

            Status.Items.Add("Đang làm việc");
            Status.Items.Add("Đã nghỉ việc");

            var departments = DataManager.GetInstance().DepartmentService.Departments;
            if (departments != null)
            {
                foreach (Department department in departments)
                {
                    Department.Items.Add(department.Name);
                }
            }
            var positions = DataManager.GetInstance().PositionService.Positions;
            if (positions != null)
            {
                foreach (var position in positions)
                {
                    Position.Items.Add(position.Name);
                }
            }
            var employees = DataManager.GetInstance().EmployeeService.Employees;
            if (employees != null)
            {
                FillDataGridView(employees);
            }

        }

        private void listEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listEmployee.SelectedRows.Count > 0)
            {
                Alert alert = new Alert();
                alert.ShowAlert("select", Alert.EnumType.INFO);
                selectRow = listEmployee.SelectedRows[0];
            }
        }

        public void Open()
        {
            Show();
        }

        public void Init()
        {
            
        }

        private void FillDataGridView(List<Employee> employees)
        {
            /*var departments = DataManager.GetInstance().DepartmentService.Departments;
            if (departments == null)
            {
                return;
            }
            var positions = DataManager.GetInstance().PositionService.Positions;
            if (positions == null)
            {
                return;
            }*/
            listEmployee.Rows.Clear();
            foreach (Employee employee in employees)
            {
                /*string departmentName = departments.SingleOrDefault(e=> e.Id == employee.Department.Id).Name;
                string positionName = positions.SingleOrDefault(e => e.Id == employee.Position.Id).Name;*/
                listEmployee.Rows.Add(employee.EmployeeID, employee.FullName, employee.DateOfBirth.ToString("dd/MM/yyyy"), employee.Gender, employee.PhoneNumber, employee.Email, employee.Address, employee.Department.Name, employee.Position.Name, employee.StartDate.ToString("dd/MM/yyyy"), employee.EndDate.ToString("dd/MM/yyyy"), Status.Items[employee.Status]);
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var employees = DataManager.GetInstance().EmployeeService.Employees;
            if (employees != null)
            {
                FillDataGridView(employees);
            }
            Alert alert = new Alert();
            alert.ShowAlert("Làm mới thành công!", Alert.EnumType.SUCCESS);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Texts;
            if (!string.IsNullOrEmpty(keyword))
            {
                Search(keyword);
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txtKeyword.Texts;
                if (!string.IsNullOrEmpty(keyword))
                {
                    Search(keyword);
                }
            }
        }
        private void Search(string keyword)
        {
            var employees = DataManager.GetInstance().EmployeeService.Employees;
            if (employees != null)
            {
                List<Employee> list = employees.FindAll(x => x.FullName.Contains(keyword));
                FillDataGridView(list);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listEmployee.Rows.Add();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.ShowAlert("delete", Alert.EnumType.INFO);
        }
    }
}
