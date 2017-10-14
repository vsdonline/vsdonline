using System;
using System.ComponentModel.DataAnnotations;

namespace VSDOnline.Models
{
    public class Chanting
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Mantra Count")]
        [DataType(DataType.Currency)]
        public int MantraCount { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        private bool? approved;
        [Display(Name = "Approved")]
        public bool? Approved
        {
            get { return approved ?? false; }
            set { approved = value; }
        }

        private DateTime? createdate;
        [Display(Name = "CreateDate")]
        public DateTime? CreateDate
        {
            get { return createdate ?? DateTime.Now; }
            set { createdate = value; }
        }

        //[Required]

        //[DataType(DataType.Password)]

        //[Display(Name = "Password")]

        //public string Password { get; set; }




        //[Display(Name = "Remember me?")]

        //public bool RememberMe { get; set; }

    }

}