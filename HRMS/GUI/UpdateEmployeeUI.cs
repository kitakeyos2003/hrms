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
            int departmentIndex = 0, positionIndex = 0;
            List<Department> departments = DataManager.GetInstance().Departments;
            foreach (Department department in departments)
            {
                if (Employee.Department.Name.Equals(department.Name))
                {
                    departmentIndex = cbDepartment.Items.Count;
                }
                cbDepartment.Items.Add(department.Name);
            }
            List<Position> positions = DataManager.GetInstance().Positions;
            foreach (Position position in positions)
            {
                if (Employee.Position.Name.Equals(position.Name))
                {
                    positionIndex = cbDepartment.Items.Count;
                }
                cbPosition.Items.Add(position.Name);
            }
            cbDepartment.SelectedIndex = departmentIndex;
            cbPosition.SelectedIndex = positionIndex;
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

        }
    }
}
