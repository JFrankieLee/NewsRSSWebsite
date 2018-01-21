using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsWebsite.Models;

namespace NewsWebsite.Controllers
{
    public class RSSFeedController : Controller
    {
        // GET: RSSFeed
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String RSSURL)
        {
            NewsItemModel model = new NewsItemModel();

            ViewBag.RSSFeed = model.newsFd;
            return View();
        }
    }
}