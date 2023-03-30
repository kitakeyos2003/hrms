using HRMS.DAL;
using HRMS.DAL.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class CandidateUI : Form, ITab
    {
        private Panel panel;
        public CandidateUI(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            this.BackColor = panel.BackColor;
            InitDataGridView();
        }

        public void InitDataGridView()
        {
            List<Candidate> candidates = DataManager.GetInstance().Candidates;
            FillDataGridView(candidates);
        }

        private void FillDataGridView(List<Candidate> candidates)
        {
            listCandidate.Rows.Clear();
            foreach (Candidate candidate in candidates)
            {
                listCandidate.Rows.Add(candidate.CandidateID, candidate.FullName, candidate.PositionApplied.Name, candidate.DepartmentApplied.Name, candidate.Resume, candidate.ContactInformation, candidate.Education, candidate.WorkExperience, candidate.Skills, candidate.InterviewDate, candidate.Interviewer, GetInterviewResult(candidate.InterviewResult));
            }
        }

        public string GetInterviewResult(int index)
        {
            if (index == 1)
            {
                return "Đạt";
            } else if (index == 2)
            {
                return "Trượt";
            }
            return "Đang xét duyệt";
        }

        public void Open()
        {
            Show();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            listCandidate.Rows.Add();
        }
    }
}
