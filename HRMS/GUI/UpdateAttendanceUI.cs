using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class UpdateAttendanceUI : Form
    {

        List<Employee> Employees;
        List<Department> Departments;
        DataGridViewRow Row;
        Attendance Attendance;
        public UpdateAttendanceUI(DataGridViewRow selectedRow, Attendance attendance)
        {
            this.Row = selectedRow;
            this.Attendance = attendance;
            InitializeComponent(); 
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(98, 102, 244);
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        private void Init()
        {
            cbDepartment.Items.Clear();
            Departments = DataManager.GetInstance().Departments;
            if (Departments.Count > 0)
            {
                int dI = -1;
                for (int i = 0; i < Departments.Count; i++)
                {
                    Department department = Departments[i];
                    if (department.Id == Attendance.Employee.Department.Id)
                    {
                        dI = i;
                    }
                    cbDepartment.Items.Add(department.Name);
                }
                if (dI != -1)
                {
                    cbDepartment.SelectedIndex = dI;
                    InitFormWithDepartment(Departments[dI]);
                }
            }
            dpShiftStartTime.Value = Attendance.ShiftStartTime;
            dpShiftEndTime.Value = Attendance.ShiftEndTime;
            dpActualStartTime.Value = Attendance.ActualStartTime;
            dpActualEndTime.Value = Attendance.ActualEndTime;
            txtOvertime.Texts = Attendance.Overtime.ToString();
            txtNote.Texts = Attendance.AttendanceNote;
            cbStatus.SelectedIndex = Attendance.AttendanceStatus;
        }

        public void InitFormWithDepartment(Department department)
        {
            cbEmployee.Items.Clear();
            Employees = DataManager.GetInstance().Employees.FindAll(e => e.Department.Id == department.Id);
            if (Employees.Count > 0)
            {
                int eI = -1;
                for (int i = 0; i < Employees.Count; i++)
                {
                    Employee employee = Employees[i];
                    if (employee.EmployeeID == Attendance.Employee.EmployeeID)
                    {
                        eI = i;
                    }
                    cbEmployee.Items.Add(employee.FullName);
                }
                if (eI != -1)
                {
                    cbEmployee.SelectedIndex = eI;
                } else
                {
                    cbEmployee.SelectedIndex = 0;
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
            int status = cbStatus.SelectedIndex;
            string note = txtNote.Texts;
            int overtime;
            bool r = int.TryParse(txtOvertime.Texts, out overtime);
            if (!r)
            {
                alert.ShowAlert("Số giờ làm thêm phải là số", Alert.EnumType.WARNING);
                return;
            }
            if (shiftStartTime > shiftEndTime)
            {
                shiftEndTime = shiftEndTime.AddDays(1);
            }
            if (actualStartTime > actualEndTime)
            {
                actualEndTime = actualEndTime.AddDays(1);
            }
            Attendance attendance = new Attendance();
            attendance.AttendanceID = Attendance.AttendanceID;
            attendance.AttendanceStatus = status;
            attendance.Employee = employee;
            attendance.Date = date;
            attendance.ShiftStartTime = shiftStartTime;
            attendance.ShiftEndTime = shiftEndTime;
            attendance.ActualStartTime = actualStartTime;
            attendance.ActualEndTime = actualEndTime;
            attendance.Overtime = overtime;
            attendance.AttendanceNote = note;
            r = DataManager.GetInstance().AttendanceService.Update(attendance);
            if (r)
            {
                Attendance.AttendanceStatus = status;
                Attendance.Employee = employee;
                Attendance.Date = date;
                Attendance.ShiftStartTime = shiftStartTime;
                Attendance.ShiftEndTime = shiftEndTime;
                Attendance.ActualStartTime = actualStartTime;
                Attendance.ActualEndTime = actualEndTime;
                Attendance.Overtime = overtime;
                Attendance.AttendanceNote = note;
                UpdateRow();
                alert.ShowAlert("Cập nhật thành công", Alert.EnumType.SUCCESS);
                Close();
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

        private void UpdateRow()
        {
            Row.Cells[1].Value = Attendance.Employee.FullName;
            Row.Cells[2].Value = Attendance.Employee.Department.Name;
            Row.Cells[3].Value = Attendance.Date.ToString("dd/MM/yyyy");
            Row.Cells[4].Value = Attendance.ShiftStartTime.ToString("dd/MM/yyyy HH:mm:ss");
            Row.Cells[5].Value = Attendance.ShiftEndTime.ToString("dd/MM/yyyy HH:mm:ss");
            Row.Cells[6].Value = Attendance.ActualStartTime.ToString("dd/MM/yyyy HH:mm:ss");
            Row.Cells[7].Value = Attendance.ActualEndTime.ToString("dd/MM/yyyy HH:mm:ss");
            Row.Cells[8].Value = Attendance.Overtime;
            Row.Cells[9].Value = Attendance.AttendanceStatus == 1 ? "Điểm danh thành công" : "Chưa điểm danh";
            Row.Cells[10].Value = Attendance.AttendanceNote;
        }
    }
}
