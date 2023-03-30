using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.DAL
{
    internal class PositionService
    {
        public List<Position> Positions { get; set; }

        public RestResponse<List<Position>> GetAll()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Position", Method.Get);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<List<Position>>(request);
            return response;
        }
        public void Load()
        {
            RestResponse<List<Position>> res = GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Positions = res.Data;
            }
        }
    }
}
