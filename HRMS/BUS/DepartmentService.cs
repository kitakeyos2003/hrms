using RestSharp;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class DepartmentService : IService<Department>
    {
        public Department Add(Department e)
        {
            return null;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public RestResponse<List<Department>> GetAll()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Department", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<List<Department>>(request);
            return response;
        }

        public bool Update(Department e)
        {
            return false;
        }
    }
}
