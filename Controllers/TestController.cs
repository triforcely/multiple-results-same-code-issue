using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using multiple_results_same_code_issue.Responses;

namespace multiple_results_same_code_issue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        [ProducesResponseType(403, Type = typeof(SampleResponse1))]
        [ProducesResponseType(403, Type = typeof(SampleResponse2))]
        public ActionResult Get()
        {
            throw new NotImplementedException();
        }
    }
}
