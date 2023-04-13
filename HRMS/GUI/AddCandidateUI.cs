using HRMS.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class AddCandidateUI : Form
    {
        CandidateUI Parent;
        public AddCandidateUI(CandidateUI candidateUI)
        {
            Parent = candidateUI;
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
            string fullName = txtFullName.Texts;
            string contactInfomation = txtContactInfomation.Texts;
            string education = txtEducation.Texts;
            string workExperience = txtWorkExperience.Texts;
            string skills = txtSkills.Texts;
            string interviewer = txtInterviewer.Texts;
            int departmentIndex = cbDepartment.SelectedIndex;
            int positionIndex = cbPosition.SelectedIndex;
            DateTime interviewDate = dpInterviewDate.Value;
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
                InterviewDate = interviewDate
            };
            Candidate c = DataManager.GetInstance().CandidateService.Add(candidate);
            if (c != null)
            {
                DataManager.GetInstance().Candidates.Add(c);
                Parent.AddCandidate(c);
                alert.ShowAlert("Thêm thành công!", Alert.EnumType.SUCCESS);
            } 
            else
            {
                alert.ShowAlert("Có lỗi xảy ra!", Alert.EnumType.ERROR);
            }
        }
    }
}
