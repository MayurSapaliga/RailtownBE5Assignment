using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RailTown.Infrastructure;
using RailTown.Models;
using System.Collections.Generic;

namespace RailTown.Controllers
{
    public class UserLocationController : Controller
    {
        private readonly ILogger<UserLocationController> _logger;
        private readonly IApplicationContext _applicationContext;

        public UserLocationController(ILogger<UserLocationController> logger, IApplicationContext applicationContext)
        {
            _logger = logger;
            _applicationContext = applicationContext;
        }

        public IActionResult GetFarthestUsers()
        {
            var functionName = "GetFarthestUsers";
            var result = _applicationContext.MakeExternalCall(functionName);
            return View("UserLocation", JsonConvert.DeserializeObject<List<User>>(result.Result));
        }

       
    }
}
