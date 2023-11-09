using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatsappWebHook.Models;

namespace WhatsappWebHook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        const string VerfifyToken = "testme";

        [HttpGet("webhook")]
        public ActionResult<string> SetupWebHook([FromQuery(Name = "hub.mode")] string hubMode,
                                         [FromQuery(Name = "hub.challenge")] int hubChallenge,
                                         [FromQuery(Name = "hub.verify_token")] string hubVerifyToken)
        {
            LogManager.LogIntoLogFile("█ WebHook with get executed. ");
            LogManager.LogIntoLogFile($"█ Parameters: hub_mode={hubMode}  hub_challenge={hubChallenge}  hub_verify_token={hubVerifyToken}");

            if (!hubVerifyToken.Equals(VerfifyToken))
            {
                return Forbid("VerifyToken doesn't match");
            }
            return Ok(hubChallenge);
        }

        [HttpPost("webhook")]
        public ActionResult ReceiveNotification([FromBody] WhatsAppMessage data)
        {
            Console.WriteLine("█ WebHook with Post executed. ");
            Console.WriteLine(data);
            //write your code here...
            return Ok();
        }
    }
}
