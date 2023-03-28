using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    internal class HomeModel
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
