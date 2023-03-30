namespace HRMS.DAL.Models
{
    internal class Evaluate
    {
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public string EvaluationPeriod { get; set; }
        public string EvaluationCriteria { get; set; }
        public double EvaluationScore { get; set; }
        public string ManagerComment { get; set; }
        public string EmployeeComment { get; set; }
        public int EvaluationResult { get; set; }
        public string ImprovementPlan { get; set; }
    }
}
