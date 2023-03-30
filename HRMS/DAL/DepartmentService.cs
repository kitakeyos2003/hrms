﻿using HRMS.DAL.Models;
using HRMS.Models;
using RestSharp;
using System.Collections.Generic;

namespace HRMS.DAL
{
    internal class DepartmentService : IData
    {
        public List<Department> Departments { get; set; }

        public RestResponse<List<Department>> GetAll()
        {
            var client = new RestClient(Application.BASE_URL);
            client.AddDefaultHeader("Content-Type", "application/json");
            var request = new RestRequest("/api/Department", Method.Get);
            request.AddHeader("Authorization", "Bearer " + Application.AccessToken);
            var response = client.Execute<List<Department>>(request);
            return response;
        }
        public void Load()
        {
            RestResponse<List<Department>> res = GetAll();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Departments = res.Data;
            }
        }
    }
}
