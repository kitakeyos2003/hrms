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
    public partial class UpdateContractUI : Form
    {
        DataGridViewRow Row;
        Contract Contract;
        List<Employee> Employees;
        List<Department> Departments;
        public UpdateContractUI(DataGridViewRow row, Contract contract)
        {
            this.Row = row;
            this.Contract = contract;
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
                    if (department.Id == Contract.Employee.Department.Id)
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
            dpStartDate.Value = Contract.StartDate;
            dpEndDate.Value = Contract.EndDate;
            txtWorkingTime.Texts = Contract.WorkingTime.ToString();
            txtBasicSalary.Texts = Contract.BasicSalary.ToString();
            cbContractType.SelectedIndex = Contract.ContractType;
            txtNote.Texts = Contract.Note;

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
                    if (employee.EmployeeID == Contract.Employee.EmployeeID)
                    {
                        eI = i;
                    }
                    cbEmployee.Items.Add(employee.FullName);
                }
                if (eI != -1)
                {
                    cbEmployee.SelectedIndex = eI;
                }
                else
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
                ContractID = Contract.ContractID,
                Employee = employee,
                ContractType = contractType,
                BasicSalary = basicSalary,
                StartDate = startDate,
                EndDate = endDate,
                WorkingTime = workingTime,
                Note = note
            };
            r = DataManager.GetInstance().ContractService.Update(contract);
            if (r)
            {
                Contract.Employee = employee;
                Contract.ContractType = contractType;
                Contract.BasicSalary = basicSalary;
                Contract.StartDate = startDate;
                Contract.EndDate = endDate;
                Contract.WorkingTime = workingTime;
                Contract.Note = note;
                UpdateRow();
                Close();
                alert.ShowAlert("Cập nhật thành công!", Alert.EnumType.SUCCESS);
            }
            else
            {
                alert.ShowAlert("Có lỗi xảy ra", Alert.EnumType.ERROR);
            }
        }

        public void UpdateRow()
        {
            Row.Cells[1].Value = Contract.Employee.FullName;
            Row.Cells[2].Value = Contract.Employee.Position.Name;
            Row.Cells[3].Value = Contract.StartDate.ToString("dd/MM/yyyy");
            Row.Cells[4].Value = Contract.EndDate.ToString("dd/MM/yyyy");
            Row.Cells[5].Value = Contract.WorkingTime.ToString();
            Row.Cells[6].Value = Contract.BasicSalary;
            Row.Cells[7].Value = GetContractType(Contract.ContractType);
            Row.Cells[8].Value = Contract.Note;
        }

        public string GetContractType(int type)
        {
            if (type == 0)
            {
                return "1 năm";
            }
            else if (type == 1)
            {
                return "5 năm";
            }
            return "10 năm";
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
