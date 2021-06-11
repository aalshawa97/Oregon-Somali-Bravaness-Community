/*Abdullah Mutaz Alshawa
 * 6/9/2021
 * Event
 */
namespace Lab4WebApplication.Models.View
{
    using System.ComponentModel.DataAnnotations;

    public partial class Event
    {
        public int Id { get; set; }

        [StringLength(32)]
        public string EventName { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
