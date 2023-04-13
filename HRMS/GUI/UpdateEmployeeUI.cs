using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class UpdateEmployeeUI : Form
    {
        DataGridViewRow Row;
        Employee Employee;
        public UpdateEmployeeUI(DataGridViewRow row, Employee employee)
        {
            this.Row = row;
            this.Employee = employee;
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(98, 102, 244);
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        private void Init()
        {
            List<Department> departments = DataManager.GetInstance().Departments;
            List<Position> positions = DataManager.GetInstance().Positions;
            foreach (Department department in departments)
            {
                cbDepartment.Items.Add(department.Name);
            }
            foreach (Position position in positions)
            {
                cbPosition.Items.Add(position.Name);
            }
            int departmentIndex = departments.FindIndex(e => e.Id == Employee.Department.Id);
            int positionIndex = positions.FindIndex(e => e.Id == Employee.Position.Id);
            if (departmentIndex != -1)
            {
                cbDepartment.SelectedIndex = departmentIndex;
            }
            if (positionIndex != -1)
            {
                cbPosition.SelectedIndex = positionIndex;
            }
            txtFullName.Texts = Employee.FullName;
            for (int i = 0; i < cbGender.Items.Count; i++)
            {
                if (cbGender.Items[i].ToString().Equals(Employee.Gender))
                {
                    cbGender.SelectedIndex = i;
                    break;
                }
            }
            txtPhoneNumber.Texts = Employee.PhoneNumber;
            txtEmail.Texts = Employee.Email;
            txtAddress.Texts = Employee.Address;
            dpDateOfBirth.Value = Employee.DateOfBirth;
            dpStartEnd.Value = Employee.StartDate;
            dpEndDate.Value = Employee.EndDate;
            cbStatus.SelectedIndex = Employee.Status;
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
            string fullName = txtFullName.Texts;
            DateTime dateOfBirth = dpDateOfBirth.Value;
            string gender = cbGender.SelectedItem.ToString();
            string address = txtAddress.Texts;
            string phoneNumber = txtPhoneNumber.Texts;
            string email = txtEmail.Texts;
            int departmentIndex = cbDepartment.SelectedIndex;
            int positionIndex = cbPosition.SelectedIndex;
            DateTime startDate = dpStartEnd.Value;
            DateTime endDate = dpEndDate.Value;
            int status = cbStatus.SelectedIndex;
            Alert alert = new Alert();

            if (string.IsNullOrEmpty(fullName))
            {
                alert.ShowAlert("Vui lòng nhập họ tên!", Alert.EnumType.WARNING);
                return;
            }

            if (dateOfBirth > DateTime.Now)
            {
                alert.ShowAlert("Ngày sinh không hợp lệ!", Alert.EnumType.WARNING);
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                alert.ShowAlert("Vui lòng chọn giới tính!", Alert.EnumType.WARNING);
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                alert.ShowAlert("Vui lòng nhập địa chỉ!", Alert.EnumType.WARNING);
                return;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                alert.ShowAlert("Vui lòng nhập số điện thoại!", Alert.EnumType.WARNING);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                alert.ShowAlert("Vui lòng nhập email!", Alert.EnumType.WARNING);
                return;
            }

            if (departmentIndex < 0)
            {
                alert.ShowAlert("Vui lòng chọn phòng ban!", Alert.EnumType.WARNING);
                return;
            }

            if (positionIndex < 0)
            {
                alert.ShowAlert("Vui lòng chọn vị trí!", Alert.EnumType.WARNING);
                return;
            }
            if (startDate > endDate)
            {
                alert.ShowAlert("Ngày bắt đầu hoặc ngày kết thúc không hợp lệ!", Alert.EnumType.WARNING);
                return;
            }
            if (status < 0 || status >= cbStatus.Items.Count)
            {
                alert.ShowAlert("Trạng thái không hợp lệ", Alert.EnumType.WARNING);
                return;
            }

            Department department = DataManager.GetInstance().Departments.ElementAt(departmentIndex);
            Position position = DataManager.GetInstance().Positions.ElementAt(positionIndex);
            Employee employee = new Employee();
            employee.EmployeeID = Employee.EmployeeID;
            employee.FullName = fullName;
            employee.Gender = gender;
            employee.DateOfBirth = dateOfBirth;
            employee.Address = address;
            employee.PhoneNumber = phoneNumber;
            employee.Email = email;
            employee.StartDate = startDate;
            employee.EndDate = endDate;
            employee.Position = position;
            employee.Department = department;
            employee.Status = status;
            bool r = DataManager.GetInstance().EmployeeService.Update(employee);
            if (r)
            {
                Employee.FullName = fullName;
                Employee.Gender = gender;
                Employee.DateOfBirth = dateOfBirth;
                Employee.Address = address;
                Employee.PhoneNumber = phoneNumber;
                Employee.Email = email;
                Employee.StartDate = startDate;
                Employee.EndDate = endDate;
                Employee.Position = position;
                Employee.Department = department;
                Employee.Status = status;
                UpdateRow();
                alert.ShowAlert("Cập nhật thành công", Alert.EnumType.SUCCESS);
                Close();
            }
            else
            {
                alert.ShowAlert("Có lỗi xảy ra", Alert.EnumType.ERROR);
            }
        }

        private void UpdateRow()
        {
            Row.Cells[1].Value = Employee.FullName;
            Row.Cells[2].Value = Employee.DateOfBirth.ToString("dd/MM/yyyy");
            Row.Cells[3].Value = Employee.Gender;
            Row.Cells[4].Value = Employee.PhoneNumber;
            Row.Cells[5].Value = Employee.Email;
            Row.Cells[6].Value = Employee.Address;
            Row.Cells[7].Value = Employee.Department.Name;
            Row.Cells[8].Value = Employee.Position.Name;
            Row.Cells[9].Value = Employee.StartDate.ToString("dd/MM/yyyy");
            Row.Cells[10].Value = Employee.EndDate.ToString("dd/MM/yyyy");
            Row.Cells[11].Value = cbStatus.Items[Employee.Status].ToString();
        }
    }
}
