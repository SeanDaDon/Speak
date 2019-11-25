using System;
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
        public ActionResult Submit(int id)
        {
            
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            string payLoad = $" -a {id}";
            try
            {
                startInfo.FileName = @"/usr/bin/python";
                startInfo.Arguments = @"/home/pi/teamSpeak/speakerScript.py" + payLoad;
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception e)
            {
                return View("Error");
            }
            return View("Voice");
        }
    }
}