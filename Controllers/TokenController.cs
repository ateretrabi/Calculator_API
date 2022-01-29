using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebCalculator.IO.Models;
using WebCalculator.IO.Services;

namespace WebCalculator.IO.Controllers
{
    [Route("ateretrabi/WebCalculator/1.0.0/[Controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public string GetRandomToken()
        {
            var jwt = new JwtServices(_config);
            var token = jwt.GenerateSecurityToken();
            return token;
        }
    }
}
