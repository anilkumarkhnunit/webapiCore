using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScoreService.Service.Models
{
    public class BuildingScore
    {
        [Key]
        public Guid FacilityId { get; set; }

        public Guid SiteId { get; set; }

        public Guid ZoneId { get; set; }

        public string MyPrSiteNameoperty { get; set; }

    }
}
