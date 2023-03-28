using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    internal class Salary
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Bonus { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal Tax { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaySlip { get; set; }

        public virtual ICollection<SalaryDetail> SalaryDetails { get; set; }

        public class SalaryDetail
        {
            public int SalaryDetailID { get; set; }
            public int EmployeeID { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }
        }
    }
}
