﻿using HRMS.DAL.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL
{
    internal class HomeService
    {
        public RestResponse<HomeModel> GetInfo()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Home", Method.Get);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<HomeModel>(request);
            return response;
        }
    }
}