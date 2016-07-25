using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSDOnline.Models
{
    public class HomePageViewModel
    {
        public Event UpcomingEvent { get; set; }
        public IList<Video> Videos { get; set; }
    }
}