using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    internal class Contract
    {
        public int ContractID { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double WorkingTime { get; set; }
        public double BasicSalary { get; set; }
        public string ContractType { get; set; }
        public string Note { get; set; }
    }
}
