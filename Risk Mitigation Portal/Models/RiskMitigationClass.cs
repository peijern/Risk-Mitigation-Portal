using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Risk_Mitigation_Portal.Models
{
    public class RiskMitigationClass
    {
        public int ID { get; set; }

        [Display(Name="LC Number")]
        public string LcNumber{ get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }

    }
}