using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace utilitiesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RequestInformationController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            string ip = "";
            try
            {
               ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            }
            catch (Exception)
            {
                ip = "not detected";
            }

            return Ok(new { 
                Ip = "",
                UserAgent = Request.Headers.UserAgent,
                AcceptEncoding = Request.Headers.AcceptEncoding,
                AcceptLanguage = Request.Headers.AcceptLanguage
            });
        }
    }
}
