using HRMS.DAL.Models;
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
using System.Windows;

namespace HRMS.GUI
{
    public partial class UpdateCandidateUI : Form
    {
        DataGridViewRow Row;
        Candidate Candidate;
        public UpdateCandidateUI(DataGridViewRow row, Candidate candidate)
        {
            this.Row = row;
            this.Candidate = candidate;
            InitializeComponent(); this.Padding = new Padding(2);
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
            int departmentIndex = departments.FindIndex(e => e.Id == Candidate.DepartmentApplied.Id);
            int positionIndex = positions.FindIndex(e => e.Id == Candidate.PositionApplied.Id);
            if (departmentIndex != -1)
            {
                cbDepartment.SelectedIndex = departmentIndex;
            }
            if (positionIndex != -1)
            {
                cbPosition.SelectedIndex = positionIndex;
            }
            txtFullName.Texts = Candidate.FullName;
            txtContactInfomation.Texts = Candidate.ContactInformation;
            txtEducation.Texts = Candidate.Education;
            txtWorkExperience.Texts = Candidate.WorkExperience;
            txtSkills.Texts = Candidate.Skills;
            txtInterviewer.Texts = Candidate.Interviewer;
            cbInterviewResult.SelectedIndex = Candidate.InterviewResult;
            dpInterviewDate.Value = Candidate.InterviewDate;
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
            string contactInfomation = txtContactInfomation.Texts;
            string education = txtEducation.Texts;
            string workExperience = txtWorkExperience.Texts;
            string skills = txtSkills.Texts;
            string interviewer = txtInterviewer.Texts;
            int departmentIndex = cbDepartment.SelectedIndex;
            int positionIndex = cbPosition.SelectedIndex;
            DateTime interviewDate = dpInterviewDate.Value;
            int interviewResult = cbInterviewResult.SelectedIndex;
            Alert alert = new Alert();

            if (string.IsNullOrEmpty(fullName))
            {
                alert.ShowAlert("Vui lòng nhập họ tên!", Alert.EnumType.WARNING);
                return;
            }
            if (string.IsNullOrEmpty(contactInfomation))
            {
                alert.ShowAlert("Vui lòng nhập thông tin liên lạc!", Alert.EnumType.WARNING);
                return;
            }
            if (string.IsNullOrEmpty(education))
            {
                alert.ShowAlert("Vui lòng nhập trình độ học vấn!", Alert.EnumType.WARNING);
                return;
            }
            if (string.IsNullOrEmpty(workExperience))
            {
                alert.ShowAlert("Vui lòng nhập kinh nghiệm làm việc!", Alert.EnumType.WARNING);
                return;
            }
            if (string.IsNullOrEmpty(skills))
            {
                alert.ShowAlert("Vui lòng nhập kỹ năng làm việc!", Alert.EnumType.WARNING);
                return;
            }
            if (string.IsNullOrEmpty(interviewer))
            {
                alert.ShowAlert("Vui lòng nhập tên người phỏng vấn!", Alert.EnumType.WARNING);
                return;
            }
            if (interviewDate > DateTime.Now)
            {
                alert.ShowAlert("Ngày phỏng vấn không hợp lệ!", Alert.EnumType.WARNING);
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
            if (interviewResult < 0 || interviewResult >= cbInterviewResult.Items.Count)
            {
                alert.ShowAlert("Trạng thái không hợp lệ", Alert.EnumType.WARNING);
                return;
            }
            Department department = DataManager.GetInstance().Departments.ElementAt(departmentIndex);
            Position position = DataManager.GetInstance().Positions.ElementAt(positionIndex);
            Candidate candidate = new Candidate
            {
                FullName = fullName,
                ContactInformation = contactInfomation,
                Education = education,
                WorkExperience = workExperience,
                DepartmentApplied = department,
                PositionApplied = position,
                Skills = skills,
                Interviewer = interviewer,
                InterviewDate = interviewDate,
                InterviewResult = interviewResult
            };
            bool r = DataManager.GetInstance().CandidateService.Update(candidate);
            if (r)
            {
                Candidate.FullName = fullName;
                Candidate.ContactInformation = contactInfomation;
                Candidate.Education = education;
                Candidate.WorkExperience = workExperience;
                Candidate.DepartmentApplied = department;
                Candidate.PositionApplied = position;
                Candidate.Skills = skills;
                Candidate.Interviewer = interviewer;
                Candidate.InterviewDate = interviewDate;
                Candidate.InterviewResult = interviewResult;
                UpdateRow();
                alert.ShowAlert("Cập nhật thành công!", Alert.EnumType.SUCCESS);
                Close();
            }
            else
            {
                alert.ShowAlert("Có lỗi xảy ra!", Alert.EnumType.ERROR);
            }
        }

        private void UpdateRow()
        {
            Row.Cells[1].Value = Candidate.FullName;
            Row.Cells[2].Value = Candidate.PositionApplied.Name;
            Row.Cells[3].Value = Candidate.DepartmentApplied.Name;
            Row.Cells[4].Value = Candidate.ContactInformation;
            Row.Cells[5].Value = Candidate.Education;
            Row.Cells[6].Value = Candidate.WorkExperience;
            Row.Cells[7].Value = Candidate.Skills;
            Row.Cells[8].Value = Candidate.InterviewDate.ToString("dd/MM/yyyy");
            Row.Cells[9].Value = Candidate.Interviewer;
            Row.Cells[10].Value = cbInterviewResult.Items[Candidate.InterviewResult];
        }
    }
}
