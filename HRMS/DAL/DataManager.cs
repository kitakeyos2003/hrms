using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL
{
    internal class DataManager
    {
        private static DataManager instance = new DataManager();
        public static DataManager GetInstance()
        {
            return instance;
        }
        public EmployeeService EmployeeService { get; set; }
        public DepartmentService DepartmentService { get; set; }
        public PositionService PositionService { get; set; }

        public DataManager()
        {
            EmployeeService = new EmployeeService();
            DepartmentService = new DepartmentService();
            PositionService = new PositionService();
        }

        public void LoadAll()
        {
            EmployeeService.Load();
            DepartmentService.Load();
        }
    }
}
