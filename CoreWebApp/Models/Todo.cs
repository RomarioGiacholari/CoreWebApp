using System.ComponentModel.DataAnnotations;

namespace CoreWebApp.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
