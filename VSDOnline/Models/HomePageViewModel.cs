using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VSDOnline.Models
{
    public class HomePageViewModel
    {
        public Event UpcomingEvent { get; set; }
        public IList<Video> Videos { get; set; }
        public IList<Photos> Photos { get; set; }
        public IList<SiteConfig> siteConfig { get; set; }
    }
}