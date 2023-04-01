using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

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
        public EvaluationService EvaluationService { get; set; }
        public AttendanceService AttendanceService { get; set; }
        public CandidateService CandidateService { get; set; }
        public ContractService ContractService { get; set; }
        public SalaryService SalaryService { get; set; }


        public List<Employee> Employees { get; set; }
        public List<Position> Positions { get; set; }
        public List<Department> Departments { get; set; }
        public List<Evaluate> Evaluations { get; set; }
        public List<Attendance> Attendances { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<Salary> Salarys { get; set; }

        public DataManager()
        {
            EmployeeService = new EmployeeService();
            DepartmentService = new DepartmentService();
            PositionService = new PositionService();
            EvaluationService = new EvaluationService();
            AttendanceService = new AttendanceService();
            CandidateService = new CandidateService();
            ContractService = new ContractService();
            SalaryService = new SalaryService();
        }

        public void LoadAll()
        {
            LoadAllEmployee();
            LoadAllDepartment();
            LoadAllPosition();
            LoadAllEvaluate();
            LoadAllAttendance();
            LoadAllCandidate();
            LoadAllContract();
            LoadAllSalary();
        }

        public void LoadAllEmployee()
        {
            RestResponse<List<Employee>> res = EmployeeService.GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Employees = res.Data;
            } else
            {
                Employees = new List<Employee>();
            }
        }

        private void LoadAllDepartment()
        {
            RestResponse<List<Department>> res2 = DepartmentService.GetAll();
            if (res2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Departments = res2.Data;
            } else
            {
                Departments = new List<Department>();
            }
        }

        private void LoadAllPosition()
        {
            RestResponse<List<Position>> res3 = PositionService.GetAll();
            if (res3.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Positions = res3.Data;
            } else
            {
                Positions = new List<Position>();
            }
        }

        private void LoadAllEvaluate()
        {
            RestResponse<List<Evaluate>> res = EvaluationService.GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Evaluations = res.Data;
            }
            else
            {
                Evaluations = new List<Evaluate>();
            }
        }

        private void LoadAllAttendance()
        {
            RestResponse<List<Attendance>> res = AttendanceService.GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Attendances = res.Data;
            }
            else
            {
                Attendances = new List<Attendance>();
            }
        }

        public void LoadAllCandidate()
        {
            RestResponse<List<Candidate>> res = CandidateService.GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Candidates = res.Data;
            }
            else
            {
                Candidates = new List<Candidate>();
            }
        }

        private void LoadAllContract()
        {
            RestResponse<List<Contract>> res = ContractService.GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Contracts = res.Data;
            }
            else
            {
                Contracts = new List<Contract>();
            }
        }

        private void LoadAllSalary()
        {
            RestResponse<List<Salary>> res = SalaryService.GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Salarys = res.Data;
            }
            else
            {
                Salarys = new List<Salary>();
            }
        }
    }
}
