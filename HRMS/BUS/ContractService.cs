using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class ContractService
    {
        public RestResponse<List<Contract>> GetAll()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Contract", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<List<Contract>>(request);
            return response;
        }
    }
}