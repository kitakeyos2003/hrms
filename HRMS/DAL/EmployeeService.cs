using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

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

        public Employee Add(Employee employee)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Employee", Method.Post);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            request.AddJsonBody(employee);
            var response = client.Execute<Employee>(request);
            return response != null ? response.Data : null;
        }

        public bool Update(Employee employee)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Employee", Method.Put);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            request.AddJsonBody(employee);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Employee?id=" + id, Method.Delete);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
