using HRMS.DAL.Models;
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
            return response != null ? response.Data : null;
        }
    }
}