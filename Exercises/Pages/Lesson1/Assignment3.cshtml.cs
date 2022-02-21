using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        [BindProperty]
        public int Input1 { get; set; } = 0;

        [BindProperty]
        public int Input2 { get; set; }

        [BindProperty]
        public int Result { get; set; } = 0;

        public void OnPostAdd()
        {
            Result = Input1 + Input2;
            Input1 = Result;
        }

        public void OnPostSub()
        {
            Result = Input1 - Input2;
            Input1 = Result;
        }

        public void OnPostMult()
        {
            Result = Input1 * Input2;
            Input1 = Result;
        }

        public IActionResult OnPostDiv()
        {
            if (Input1 == 0 || Input2 == 0)
            {
                return BadRequest("Delen door nul is niet toegestaan");
            }

            Result = Input1 / Input2;
            Input1 = Result;

            return Page();
        }

    }
}
