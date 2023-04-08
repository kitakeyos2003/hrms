using HRMS.DAL;
using HRMS.DAL.Models;
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
    public partial class AddAttendanceUI : Form
    {
        AttendanceUI Parent;
        List<Employee> Employees;
        List<Department> Departments;
        public AddAttendanceUI(AttendanceUI parent)
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

            if (dpDate.Value == null || dpShiftStartTime.Value == null || dpShiftEndTime.Value == null)
            {
                alert.ShowAlert("Vui lòng nhập đầy đủ ngày và giờ làm việc", Alert.EnumType.WARNING);
                return;
            }

            Employee employee = Employees[cbEmployee.SelectedIndex];
            DateTime date = dpDate.Value;
            DateTime shiftStartTime = dpShiftStartTime.Value;
            DateTime shiftEndTime = dpShiftEndTime.Value;
            DateTime actualStartTime = dpActualStartTime.Value;
            DateTime actualEndTime = dpActualEndTime.Value;
            string note = txtNote.Texts;
            int overtime;
            bool r = int.TryParse(txtOvertime.Texts, out overtime);
            if (!r)
            {
                alert.ShowAlert("Số giờ làm thêm phải là 1 số", Alert.EnumType.WARNING);
                return;
            }
            if (shiftStartTime > shiftEndTime)
            {
                alert.ShowAlert("Thời gian bắt đầu ca phải trước thời gian kết thúc", Alert.EnumType.WARNING);
                return;
            }
            if (actualStartTime > actualEndTime)
            {
                alert.ShowAlert("Thời gian bắt đầu thực tế phải trước thời gian kết thúc", Alert.EnumType.WARNING);
                return;
            }
            alert.ShowAlert("Thêm thành công!", Alert.EnumType.SUCCESS);
            Attendance attendance = new Attendance();
            attendance.AttendanceStatus = 1;
            attendance.Employee = employee;
            attendance.Date = date;
            attendance.ShiftStartTime = shiftStartTime;
            attendance.ShiftEndTime = shiftEndTime;
            attendance.ActualStartTime = actualStartTime;
            attendance.ActualEndTime = actualEndTime;
            attendance.Overtime = overtime;
            attendance.AttendanceNote = note;
            Attendance na = DataManager.GetInstance().AttendanceService.Add(attendance);
            if (na != null)
            {
                DataManager.GetInstance().Attendances.Add(na);
                Parent.AddAttendance(na);
                alert.ShowAlert("Thêm thành công!", Alert.EnumType.SUCCESS);
            } else
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
            } else
            {
                cbEmployee.SelectedIndex = -1;
                cbEmployee.Texts = string.Empty;
            }
        }
    }
}
