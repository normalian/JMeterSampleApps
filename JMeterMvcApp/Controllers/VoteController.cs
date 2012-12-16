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

        [HttpGet]
        public ActionResult Select(int id)
        {
            if (id < 0 || id >= VoteCandidateFactory.VoteCandidates.Count())
            {
                TempData["Message"] = "選択が不正です('A`)。再度選択してください。";
                return RedirectToAction("Index");
            }

            return View(VoteCandidateFactory.VoteCandidates[id]);
        }

        [HttpPost]
        public ActionResult Select(FormCollection formCollection)
        {
            string comment = formCollection["comment"];
            int id = -1;
            if (int.TryParse(formCollection["id"], out id) == false)
            {
                TempData["Message"] = "選択が不正っぽいです('A`)。再度投票してください。";
                return RedirectToAction("Index");
            }
            TempData["Comment"] = comment;
            TempData["Id"] = id;
            return RedirectToAction("End");
        }

        [HttpGet]
        public ActionResult End()
        {
            int id = -1;
            try
            {
                if (int.TryParse(TempData["Id"].ToString(), out id) == false)
                {
                    TempData["Message"] = "選択が不正っぽいです('A`)。再度投票してください。";
                    return RedirectToAction("Index");
                }
                ViewBag.Comment = TempData["Comment"];
            }
            catch (Exception ex)
            {
                TempData["Message"] = "不正な操作っぽいです('A`)。再度投票してください。";
                return RedirectToAction("Index");
            }

            return View(VoteCandidateFactory.VoteCandidates[id]);
        }
    }
}
