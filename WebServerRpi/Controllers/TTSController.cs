using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebServerRpi.Controllers
{
    public class TTSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}