﻿using HRMS.DAL.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.DAL
{
    internal class CandidateService
    {
        public RestResponse<List<Candidate>> GetAll()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Candidate", Method.Get);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<List<Candidate>>(request);
            return response;
        }

        public Candidate Add(Candidate candidate)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Candidate", Method.Post);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            request.AddJsonBody(candidate);
            var response = client.Execute<Candidate>(request);
            return response != null ? response.Data : null;
        }

        public bool Update(Candidate candidate)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Candidate", Method.Put);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            request.AddJsonBody(candidate);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Candidate?id=" + id, Method.Delete);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
