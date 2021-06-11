/*
 * Abdullah Mutaz Alshawa
 * 6/9/2021
 * Event view model
 */
using System.ComponentModel.DataAnnotations;

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