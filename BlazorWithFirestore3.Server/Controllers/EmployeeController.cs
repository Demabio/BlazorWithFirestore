﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWithFirestore3.Server.DataAccess;
using BlazorWithFirestore3.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWithFirestore3.Server.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        [HttpGet]
        public Task<List<Employee>> Get()
        {
            return objemployee.GetAllEmployees();
        }
        [HttpGet("{id}")]
        public Task<Employee> Get(string id)
        {
            return objemployee.GetEmployeeData(id);
        }
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            objemployee.AddEmployee(employee);
        }
        [HttpPut]
        public void Put([FromBody]Employee employee)
        {
            objemployee.UpdateEmployee(employee);
        }
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            objemployee.DeleteEmployee(id);
        }
        [HttpGet("GetCities")]
        public Task<List<Cities>> GetCities()
        {
            return objemployee.GetCityData();
        }
    }
}
