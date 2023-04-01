using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string FullName { get; set; }
        public Position PositionApplied { get; set; }
        public Department DepartmentApplied { get; set; }
        public string ContactInformation { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public string Skills { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Interviewer { get; set; }
        public int InterviewResult { get; set; }
    }
}
