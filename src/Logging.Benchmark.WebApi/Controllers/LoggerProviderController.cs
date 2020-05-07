using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Logging.Benchmark.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggerProviderController : ControllerBase
    {
        private readonly LoggerSettings _settings;

        public LoggerProviderController(LoggerSettings settings)
        {
            _settings = settings;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_settings);
        }
    }
}
