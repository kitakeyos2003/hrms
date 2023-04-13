using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AddEmployeeUI : Form
    {
        private EmployeeUI Parent;
        public AddEmployeeUI(EmployeeUI employeeUI)
        {
            this.Parent = employeeUI;
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(98, 102, 244);
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        private void Init()
        {
            List<Department> departments = DataManager.GetInstance().Departments;
            if (departments.Count > 0)
            {
                foreach (Department department in departments)
                {
                    cbDepartment.Items.Add(department.Name);
                }
                cbDepartment.SelectedIndex = 0;
            }
            List<Position> positions = DataManager.GetInstance().Positions;
            if (positions.Count > 0)
            {
                foreach (Position position in positions)
                {
                    cbPosition.Items.Add(position.Name);
                }
                cbPosition.SelectedIndex = 0;
            }
            cbGender.SelectedIndex = 0;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string fullName = txtFullName.Texts;
            DateTime dateOfBirth = dpDateOfBirth.Value;
            string gender = cbGender.SelectedItem.ToString();
            string address = txtAddress.Texts;
            string phoneNumber = txtPhoneNumber.Texts;
            string email = txtEmail.Texts;
            int departmentIndex = cbDepartment.SelectedIndex;
            int positionIndex = cbPosition.SelectedIndex;
            int salary;
            DateTime startDate = dpStartDate.Value;
            DateTime endDate = dpEndDate.Value;
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
            Department department = DataManager.GetInstance().Departments.ElementAt(departmentIndex);
            Position position = DataManager.GetInstance().Positions.ElementAt(positionIndex);
            Employee employee = new Employee();
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
            Employee ne = DataManager.GetInstance().EmployeeService.Add(employee);
            if (ne != null)
            {
                DataManager.GetInstance().Employees.Add(ne);
                Parent.AddEmployee(ne);
                alert.ShowAlert("Thêm thành công!", Alert.EnumType.SUCCESS);
            } else
            {
                alert.ShowAlert("Có lỗi xảy ra", Alert.EnumType.ERROR);
            }


        }
    }
}
