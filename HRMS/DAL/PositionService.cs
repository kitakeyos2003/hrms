using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.DAL
{
    internal class PositionService
    {

        public RestResponse<List<Position>> GetAll()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Position", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<List<Position>>(request);
            return response;
        }
    }
}
