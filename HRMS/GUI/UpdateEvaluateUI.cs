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
    public partial class UpdateEvaluateUI : Form
    {
        DataGridViewRow Row;
        Evaluate Evaluate;
        List<Employee> Employees;
        List<Department> Departments;
        public UpdateEvaluateUI(DataGridViewRow row, Evaluate rvaluate)
        {
            this.Row = row;
            this.Evaluate = rvaluate;
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
                    if (department.Id == Evaluate.Employee.Department.Id)
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
            txtEvaluationCriteria.Texts = Evaluate.EvaluationCriteria;
            txtEvaluationScore.Texts = Evaluate.EvaluationScore.ToString();
            dpEvaluationPeriod.Value = Evaluate.EvaluationPeriod;
            txtManagerComment.Texts = Evaluate.ManagerComment;
            txtEmployeeComment.Texts = Evaluate.EmployeeComment;
            txtEvaluationResult.Texts = Evaluate.EvaluationResult.ToString();
            txtImprovementPlan.Texts = Evaluate.ImprovementPlan;
            
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
                    if (employee.EmployeeID == Evaluate.Employee.EmployeeID)
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

            if (dpEvaluationPeriod.Value == null)
            {
                alert.ShowAlert("Vui lòng nhập ngày đánh giá", Alert.EnumType.WARNING);
                return;
            }

            Employee employee = Employees[cbEmployee.SelectedIndex];
            DateTime evaluationPeriod = dpEvaluationPeriod.Value;
            string evaluationCriteria = txtEvaluationCriteria.Texts;
            double evaluationScore;
            string improvementPlan = txtImprovementPlan.Texts;
            bool r = double.TryParse(txtEvaluationScore.Texts, out evaluationScore);
            if (!r)
            {
                alert.ShowAlert("Điểm đánh giá không hợp lệ", Alert.EnumType.WARNING);
                return;
            }
            string managerComment = txtManagerComment.Texts;
            string employeeComment = txtEmployeeComment.Texts;
            int evaluationResult;
            r = int.TryParse(txtEvaluationResult.Texts, out evaluationResult);
            if (!r)
            {
                alert.ShowAlert("Kết quả đánh giá không hợp lệ", Alert.EnumType.WARNING);
                return;
            }

            Evaluate evaluate = new Evaluate
            {
                EvaluateID = Evaluate.EvaluateID,
                Employee = employee,
                EvaluationPeriod = evaluationPeriod,
                EvaluationScore = evaluationScore,
                EvaluationCriteria = evaluationCriteria,
                ImprovementPlan = improvementPlan,
                ManagerComment = managerComment,
                EmployeeComment = employeeComment,
                EvaluationResult = evaluationResult

            };

            r = DataManager.GetInstance().EvaluationService.Update(evaluate);
            if (r)
            {
                Evaluate.Employee = employee;
                Evaluate.EvaluationPeriod = evaluationPeriod;
                Evaluate.EvaluationScore = evaluationScore;
                Evaluate.EvaluationCriteria = evaluationCriteria;
                Evaluate.ImprovementPlan = improvementPlan;
                Evaluate.ManagerComment = managerComment;
                Evaluate.EmployeeComment = employeeComment;
                Evaluate.EvaluationResult = evaluationResult;
                UpdateRow();
                Close();
                alert.ShowAlert("Cập nhật thành công!", Alert.EnumType.SUCCESS);
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
            Row.Cells[1].Value = Evaluate.Employee.FullName;
            Row.Cells[2].Value = Evaluate.Employee.Department.Name;
            Row.Cells[3].Value = Evaluate.EvaluationPeriod.ToString("dd/MM/yyyy");
            Row.Cells[4].Value = Evaluate.EvaluationCriteria;
            Row.Cells[5].Value = Evaluate.EvaluationScore;
            Row.Cells[6].Value = Evaluate.ManagerComment;
            Row.Cells[7].Value = Evaluate.EmployeeComment;
            Row.Cells[8].Value = Evaluate.EvaluationResult;
            Row.Cells[9].Value = Evaluate.ImprovementPlan;
        }
    }
}
