using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassFeedback.Controllers
{
    public class RoomBuildController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
