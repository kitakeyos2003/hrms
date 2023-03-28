using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    internal class EmployeeEvaluation
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string EvaluationPeriod { get; set; }
        public string EvaluationCriteria { get; set; }
        public double EvaluationScore { get; set; }
        public string ManagerComment { get; set; }
        public string EmployeeComment { get; set; }
        public string EvaluationResult { get; set; }
        public string ImprovementPlan { get; set; }
    }
}
