using System;
using HostNameInfoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HostNameInfoAPI.Controllers
{
    [Route("api/hostnameInfo")]
    [ApiController]
    public class HostNameInfoController: ControllerBase
    {

        [HttpGet]
        public ActionResult <HostNameInfoModel> GetHostNameInformation()
        {
            var hostInfo = new HostNameInfoModel();            
            return Ok(hostInfo.GetHostNameInfo());       
        }
    }
}