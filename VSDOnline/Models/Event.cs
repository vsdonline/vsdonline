using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VSDOnline.Models
{
    public class Event
    {
        public int ID { get; set; }

        [AllowHtml]
        public string Name { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        [AllowHtml]
        public string Date { get; set; }

        [AllowHtml]
        public string Time { get; set; }

        [AllowHtml]
        public string Venue { get; set; }

        [AllowHtml]
        public string ContactDetails { get; set; }
    }
}