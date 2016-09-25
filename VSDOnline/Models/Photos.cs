using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VSDOnline.Models
{
    public class Photos
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Image Url")]
        public string ImageLink { get; set; }

        [Display(Name = "Album Url")]
        public string AlbumLink { get; set; }
    }
}