using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebServerRpi.Controllers
{
    public class VoiceController : Controller
    {

        public IActionResult Voice()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Submit(int id, string name)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = @"usr/bin/python";
                startInfo.Arguments = @"home/pi/test/python motorScript.py -i yo -a 1";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch(Exception e)
            {
                //Implement some form of logging...
                return View("Index");
            }
            return View("Voice");
        }

    }
}