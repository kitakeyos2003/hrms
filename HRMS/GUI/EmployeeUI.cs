using HRMS.DAL;
using HRMS.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class EmployeeUI : Form, ITab
    {
        private Panel panel;
        DataGridViewRow selectRow;
        EmployeeService service;
        List<Employee> employees;
        public EmployeeUI(Panel panel)
        {
            this.panel = panel;
            service = new EmployeeService();
            InitializeComponent();
            this.BackColor = panel.BackColor;
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
            RestResponse<List<Employee>> res = service.GetAll();
            if (res.StatusCode == HttpStatusCode.OK)
            {
                employees = res.Data;
            }
            FillDataGridView(employees);
        }

        private void FillDataGridView(List<Employee> employees)
        {
            listEmployee.Rows.Clear();
            foreach (Employee employee in employees)
            {
                //listEmployee.Rows.Add(employee.EmployeeID, employee.FullName, employee.DateOfBirth.ToString("dd/MM/yyyy"), employee.Gender, employee.Address, employee.PhoneNumber, employee.Department.Name, employee.Position.Name);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillDataGridView(employees);
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
            List<Employee> list = employees.FindAll(x => x.FullName.Contains(keyword));
            FillDataGridView(list);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.ShowAlert("add", Alert.EnumType.INFO);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.ShowAlert("edit", Alert.EnumType.INFO);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.ShowAlert("delete", Alert.EnumType.INFO);
        }
    }
}
