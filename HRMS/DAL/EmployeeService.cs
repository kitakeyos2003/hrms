using HRMS.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL
{
    internal class EmployeeService
    {
        public RestResponse<List<Employee>>GetAll()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Employee", Method.Get); 
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<List<Employee>>(request);
            return response;
        }
    }
}
