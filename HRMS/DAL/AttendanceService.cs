﻿using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.DAL
{
    internal class AttendanceService
    {
        public RestResponse<List<Attendance>> GetAll()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Attendance", Method.Get);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<List<Attendance>>(request);
            return response;
        }
    }
}