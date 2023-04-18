using HRMS.DAL;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AddSalaryUI : Form
    {
        SalaryCalculatorUI Parent;
        List<Employee> Employees;
        List<Department> Departments;
        List<Position> Positions;
        Department department;
        Position position; 
        Employee employee;

        public AddSalaryUI(SalaryCalculatorUI parent)
        {
            this.Parent = parent;
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(98, 102, 244);
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        public void Init()
        {
            DateTime now = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            dpStartDate.Value = firstDayOfMonth;
            dpEndDate.Value = lastDayOfMonth;
            cbDepartment.Items.Add("Tất cả");
            Departments = DataManager.GetInstance().Departments;
            for (int i = 0; i < Departments.Count; i++)
            {
                Department department = Departments[i];
                cbDepartment.Items.Add(department.Name);
            }
            cbDepartment.SelectedIndex = 0;


            cbPosition.Items.Add("Tất cả");
            Positions = DataManager.GetInstance().Positions;
            for (int i = 0; i < Positions.Count; i++)
            {
                Position position = Positions[i];
                cbPosition.Items.Add(position.Name);
            }
            cbPosition.SelectedIndex = 0;

            InitComoboBoxEmployee();

        }

        public void InitComoboBoxEmployee()
        {

            cbEmployee.Items.Clear();
            cbEmployee.Items.Add("Tất cả");
            Employees = DataManager.GetInstance().Employees.FindAll(e => IsMatch(e));
            foreach (Employee employee in Employees)
            {
                cbEmployee.Items.Add(employee.FullName);
            }
            cbEmployee.SelectedIndex = 0;

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                // Xóa title bar
                m.Result = IntPtr.Zero;
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool IsMatch(Employee employee)
        {
            return (department == null || department.Id == employee.Department.Id) && (position == null || position.Id == employee.Position.Id);
        }

        private void cbDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex > 0)
            {
                department = Departments[cbDepartment.SelectedIndex - 1];
            }
            else
            {
                department = null;
            }
            InitComoboBoxEmployee();
        }

        private void cbPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedIndex > 0)
            {
                position = Positions[cbPosition.SelectedIndex - 1];
            }
            else
            {
                position = null;
            }
            InitComoboBoxEmployee();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            DateTime startDate = dpStartDate.Value;
            DateTime endDate = dpEndDate.Value;
            if (startDate >= endDate)
            {
                alert.ShowAlert("Thời gian bắt đầu hoặc thời gian kết thúc không hợp lệ!", Alert.EnumType.SUCCESS);
                return; 
            }
            List<Employee> list = Employees.FindAll(em => employee == null || employee.EmployeeID == em.EmployeeID);
            if (list.Count > 0)
            {
                RestResponse<List<Salary>> response = DataManager.GetInstance().SalaryService.Generate(list, startDate, endDate);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (Salary salary in response.Data)
                    {
                        Parent.AddSalary(salary);
                    }
                    alert.ShowAlert("Tính lương thành công", Alert.EnumType.SUCCESS);
                } else
                {
                    alert.ShowAlert("Có lỗi xảy ra! [" + response.StatusCode + "]", Alert.EnumType.ERROR);
                }
                
            } else
            {
                alert.ShowAlert("Không tìm thấy nhân viên nào", Alert.EnumType.WARNING);
            }
        }

        private void cbEmployee_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployee.SelectedIndex > 0)
            {
                employee = Employees[cbEmployee.SelectedIndex - 1];
            }
            else
            {
                employee = null;
            }
        }
    }
}
