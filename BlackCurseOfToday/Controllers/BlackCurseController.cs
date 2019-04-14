using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackCurseOfToday.Models.Application.Factory;
using BlackCurseOfToday.Models.Application.Value;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackCurseOfToday.Controllers
{
    public class BlackCurseController : Controller
    {
        public ActionResult WhichJob()
        {
            var jobList = JobListGenerater.ShufflePickUp(4).ToList();
            var view = new WhichJobView(jobList);

            return View(view);
        }
    }
}