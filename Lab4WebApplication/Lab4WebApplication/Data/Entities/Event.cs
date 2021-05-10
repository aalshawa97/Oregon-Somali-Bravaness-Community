using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4WebApplication.Data.Entities
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32)]
        public string EventName { get; set; }
    }
}