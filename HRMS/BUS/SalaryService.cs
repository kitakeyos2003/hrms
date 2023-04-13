using RestSharp;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class SalaryService
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
    }
}