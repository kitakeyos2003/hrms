using RestSharp;
using System;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class SalaryService : IService<Salary>
    {
        public RestResponse<List<Salary>> GetAll()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Salary", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<List<Salary>>(request);
            return response;
        }

        public RestResponse<List<Salary>> Generate(List<Employee> models, DateTime startDate, DateTime endDate)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            client.AddDefaultHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var request = new RestRequest("/api/Salary/GenerateSalary", Method.Post);
            request.AddQueryParameter("startDate", startDate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            request.AddQueryParameter("endDate", endDate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            request.AddJsonBody(models);
            var response = client.Execute<List<Salary>>(request);
            return response;
        }

        public Salary Add(Salary e)
        {
            return null;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public bool Update(Salary e)
        {
            return false;
        }
    }
}