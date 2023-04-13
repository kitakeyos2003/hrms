using RestSharp;
using System;
using System.Collections.Generic;

namespace HRMS.BUS
{
    internal class AttendanceService
    {
        public RestResponse<List<Attendance>> GetAll()
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Attendance", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute<List<Attendance>>(request);
            return response;
        }

        public Attendance Add(Attendance attendance)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Attendance", Method.Post);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            request.AddJsonBody(attendance);
            var response = client.Execute<Attendance>(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK ? response.Data : null;
        }

        public bool Delete(int attendanceID)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Attendance?id=" + attendanceID, Method.Delete);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool Update(Attendance attendance)
        {
            var client = new RestClient(ApplicationConfig.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Attendance", Method.Put);
            request.AddHeader("Authorization", "Bearer " + ApplicationConfig.Token.AccessToken);
            request.AddJsonBody(attendance);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}