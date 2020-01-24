using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Risk_Mitigation_Portal.Models;
using System.Net.Http;


namespace Risk_Mitigation_Portal.Controllers
{
    public class InsertrmtController : Controller
    {
        // GET: Insertrmt
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RiskMitigationClass ed)
        {

            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:59972/api/RiskMitigationCrud");

            var insertrec = hc.PostAsJsonAsync<RiskMitigationClass>("RiskMitigationCrud", ed);
            insertrec.Wait();

            ViewBag.message="Record "+ ed.Name + " Is inserted sucessfully....!";
            return View();
        }
    }
}