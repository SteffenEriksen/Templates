using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using template.Entities.Models;
using template.Helpers;
using template.Services.Interface;

namespace template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private IService _service;
        private IConfiguration _config;

        public ApiController(IService service, IConfiguration config)
        {
            _service = service;
            _config = config;
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
            var exampleConfig = new ExampleConfig(_config);
            var baseUrl = exampleConfig.ExampleApiBaseUrl;

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