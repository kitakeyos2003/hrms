using RestSharp;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class PositionService : IService<Position>
    {
        public Position Add(Position e)
        {
            return null;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public RestResponse<List<Position>> GetAll()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Position", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<List<Position>>(request);
            return response;
        }

        public bool Update(Position e)
        {
            return false;
        }
    }
}
