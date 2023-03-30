namespace HRMS.DAL.Models
{
    internal class Home
    {
        public int TotalEmployees { get; set; }
        public int NewEmployeesThisMonth { get; set; }
        public int NewEmployeesLastMonth { get; set; }
        public int SuccessfulProbationThisMonth { get; set; }
        public int SuccessfulProbationLastMonth { get; set; }
        public int ResignedThisMonth { get; set; }
        public int ResignedLastMonth { get; set; }
    }
}
