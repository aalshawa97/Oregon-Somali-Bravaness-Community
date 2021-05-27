namespace Lab4WebApplication.Models.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public int Id { get; set; }

        [StringLength(32)]
        public string EventName { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
