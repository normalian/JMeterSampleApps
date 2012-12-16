using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JMeterApp.Common.Models;

namespace JMeterApp.Mvc.Controllers
{
    public class VoteController : Controller
    {
        //
        // GET: /Vote/
        public ActionResult Index()
        {
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }
            return View(VoteCandidateFactory.VoteCandidates);
        }

        public ActionResult Select(int id)
        {
            if (id < 0 || id >= VoteCandidateFactory.VoteCandidates.Count())
            {
                TempData["Message"] = "選択が不正です('A`)。再度選択してください。";
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
