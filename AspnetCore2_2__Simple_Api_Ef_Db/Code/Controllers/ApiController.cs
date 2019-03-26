﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using template.Entities.Models;
using template.Services.Interface;

namespace template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private IService _service;
        public ApiController(IService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("Ping")]
        public ActionResult Ping()
        {
            return Ok("Pong");
        }

        [HttpGet]
        [Route("GetFromDbTest")]
        public ActionResult GetFromDbTest()
        {
            ExampleModel res;
            try
            {
                res = _service.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return Ok(res);
        }


        [HttpGet]
        [Route("AddToDbTest")]
        public ActionResult<ExampleModel> AddToDbTest()
        {
            ExampleModel res;
            try
            {
                res = _service.Do();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return Ok(res);
        }

    }
}