using System.ComponentModel.DataAnnotations;

namespace Lab4WebApplication.Data.Entities
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32)]
        public string EventName { get; set; }
        public int UserId { get; internal set; }
    }
}