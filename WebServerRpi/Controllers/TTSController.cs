using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebServerRpi.Controllers
{
    public class TTSController : Controller
    {
        public IActionResult Index()
        {
            return View("Speaker");
        }

        [HttpGet]
        public ActionResult Submit(int id)
        {
            ViewBag.Id = id;

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            string payLoad = $" -a {id}";
            //try
            //{
            //    startInfo.FileName = @"/usr/bin/python";
            //    startInfo.Arguments = @"/home/pi/teamSpeak/motorScript.py" + payLoad;
            //    process.StartInfo = startInfo;
            //    process.Start();
            //}
            //catch (Exception e)
            //{
            //    //Implement some form of logging...
            //    return View("Index");
            //}
            return View("Speaker");
        }
    }
}