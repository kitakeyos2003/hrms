using RestSharp;

namespace HRMS.DAL
{
    internal class UserService 
    {
        public RestResponse<ApiResponse<Token>> Validate(string username, string password)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/User", Method.Post);
            request.AddJsonBody(new
            {
                userName = username,
                password = password
            });
            var response = client.Execute<ApiResponse<Token>>(request);
            return response;
        }
    }
}
