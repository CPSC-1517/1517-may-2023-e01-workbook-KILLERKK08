using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppSolution.Pages.Samples
{
    public class BasicEventsModel : PageModel
    {
        public string FeedBack { get; set; }

        public void OnGet()
        {
            FeedBack = "in OnGet";
        }
    }
}
