using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4WebApplication.Models.View
{
    public class EventViewModel 
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [Display(Name = "Event's Name")]
        public string Name { get; set; }
    }
}