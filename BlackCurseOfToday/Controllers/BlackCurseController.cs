using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackCurseOfToday.Controllers
{
    public class BlackCurseController : Controller
    {
        public ActionResult WhichJob()
        {
            return View();
        }
    }
}