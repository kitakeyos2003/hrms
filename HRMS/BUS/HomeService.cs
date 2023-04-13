using RestSharp;

namespace HRMS.BUS
{
    internal class HomeService
    {
        public RestResponse<Home> GetInfo()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Home", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<Home>(request);
            return response;
        }
    }
}
