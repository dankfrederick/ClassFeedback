using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassFeedback.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Page"] = "Join Room";
            return View();
        }
    }
}
