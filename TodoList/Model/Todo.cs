using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoList.Enum;

namespace TodoList.Model
{
    [Table("Todo")]
    public class Todo : ModelBase
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; } = "";
        public TodoStatus Status { get; set; }
    }
}
