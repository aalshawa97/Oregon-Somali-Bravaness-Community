/*Abdullah Mutaz Alshawa
 * 6/9/2021
 * Error View Model
 */
namespace Lab4WebApplication.Models.View
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}