using System.ComponentModel.DataAnnotations;

namespace BlazorApp_TodoList_ComIT.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public bool IsChecked { get; set; }
    }
}
