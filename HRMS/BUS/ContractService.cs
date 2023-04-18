using RestSharp;
using System;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class ContractService : IService<Contract>
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

        public Contract Add(Contract contract)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Contract", Method.Post);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            request.AddJsonBody(contract);
            var response = client.Execute<Contract>(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK ? response.Data : null;
        }

        public bool Delete(int attendanceID)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Contract?id=" + attendanceID, Method.Delete);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool Update(Contract contract)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Contract", Method.Put);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            request.AddJsonBody(contract);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}