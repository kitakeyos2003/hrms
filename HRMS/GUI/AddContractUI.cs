using HRMS.DAL;
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
    public partial class AddContractUI : Form
    {
        ContractUI Parent;
        List<Employee> Employees;
        List<Department> Departments;
        public AddContractUI(ContractUI parent)
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
            cbDepartment.Items.Clear();
            Departments = DataManager.GetInstance().Departments;
            if (Departments.Count > 0)
            {
                for (int i = 0; i < Departments.Count; i++)
                {
                    Department department = Departments[i];
                    cbDepartment.Items.Add(department.Name);
                }
                cbDepartment.SelectedIndex = 0;
                InitFormWithDepartment(Departments[0]);
            }
            cbContractType.SelectedIndex = 0;
        }
        public void InitFormWithDepartment(Department department)
        {
            cbEmployee.Items.Clear();
            Employees = DataManager.GetInstance().Employees.FindAll(e => e.Department.Id == department.Id);
            if (Employees.Count > 0)
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    Employee employee = Employees[i];
                    cbEmployee.Items.Add(employee.FullName);
                }
                cbEmployee.SelectedIndex = 0;
            }
            else
            {
                cbEmployee.SelectedIndex = -1;
                cbEmployee.Texts = string.Empty;
            }
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            if (cbEmployee.SelectedIndex == -1)
            {
                alert.ShowAlert("Vui lòng chọn một nhân viên", Alert.EnumType.WARNING);
                return;
            }

            if (dpStartDate.Value == null)
            {
                alert.ShowAlert("Vui lòng nhập ngày bắt đầu", Alert.EnumType.WARNING);
                return;
            }
            if (dpEndDate.Value == null)
            {
                alert.ShowAlert("Vui lòng nhập ngày kết thúc", Alert.EnumType.WARNING);
                return;
            }
            DateTime startDate = dpStartDate.Value;
            DateTime endDate = dpEndDate.Value;
            int workingTime;
            int basicSalary;
            int contractType = cbContractType.SelectedIndex;
            string note = txtNote.Texts;
            if (startDate > endDate)
            {
                alert.ShowAlert("Ngày bắt đầu hoặc ngày kết thúc không hợp lệ!", Alert.EnumType.WARNING);
                return;
            }
            bool r = int.TryParse(txtWorkingTime.Texts, out workingTime);
            if (!r)
            {
                alert.ShowAlert("Thời gian làm việc không hợp lệ!", Alert.EnumType.WARNING);
                return;
            }
            r = int.TryParse(txtBasicSalary.Texts, out basicSalary);
            if (!r)
            {
                alert.ShowAlert("Lương cơ bản không hợp lệ!", Alert.EnumType.WARNING);
                return;
            }
            Employee employee = Employees[cbEmployee.SelectedIndex];
            Contract contract = new Contract
            {
                Employee = employee,
                ContractType = contractType,
                BasicSalary = basicSalary,
                StartDate = startDate,
                EndDate = endDate,
                WorkingTime = workingTime,
                Note = note
            };
            Contract nc = DataManager.GetInstance().ContractService.Add(contract);
            if (nc != null)
            {
                DataManager.GetInstance().Contracts.Add(nc);
                Parent.AddContract(nc);
                alert.ShowAlert("Thêm thành công!", Alert.EnumType.SUCCESS);
            }
            else
            {
                alert.ShowAlert("Có lỗi xảy ra", Alert.EnumType.ERROR);
            }
        }

        private void cbDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex >= 0)
            {
                InitFormWithDepartment(Departments[cbDepartment.SelectedIndex]);
            }
        }
    }
}
