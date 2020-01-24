using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Risk_Mitigation_Portal.Models;

namespace Risk_Mitigation_Portal.Controllers
{
    public class RiskMitigationCrudController : ApiController
    {
        

        public IHttpActionResult insertemp (RiskMitigationClass ed)
        {
            RiskMitigationEntities rmt = new RiskMitigationEntities();
            rmt.dbo_spTracker_AddorEdit(ed.ID,ed.LcNumber, ed.Name, ed.Country, ed.Status);
            rmt.SaveChanges();
            return Ok();
        }
    }
}
