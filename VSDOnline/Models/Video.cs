﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VSDOnline.Models
{
    public class Video
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Url")]
        public string Link { get; set; }
    }
}