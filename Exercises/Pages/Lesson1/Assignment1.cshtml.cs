using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int ScoreHome { get; set; } 

        [BindProperty(SupportsGet = true)]
        public int ScoreAway { get; set; } 
        public void OnGet()
        {

        }
    }
}
