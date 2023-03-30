﻿using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.DAL
{
    internal class EvaluationService
    {
        public RestResponse<List<Evaluate>> GetAll()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Evaluation", Method.Get);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<List<Evaluate>>(request);
            return response;
        }
    }
}