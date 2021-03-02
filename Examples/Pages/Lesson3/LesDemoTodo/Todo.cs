using System.ComponentModel.DataAnnotations;

namespace Examples.Pages.Lesson3.LesDemoTodo
{
    public class Todo
    {
        public int TodoId { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Description { get; set; }

        public bool Done { get; set; }
    }
}