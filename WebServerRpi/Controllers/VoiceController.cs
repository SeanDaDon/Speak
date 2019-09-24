using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebServerRpi.Controllers
{
    public class VoiceController : Controller
    {

        public IActionResult Voice()
        {
            return View();
        }

    }
}