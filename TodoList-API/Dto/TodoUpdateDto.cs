using System.ComponentModel.DataAnnotations;
using TodoList.Enum;

namespace TodoList.Dto
{
    public class TodoUpdateDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public TodoStatus Status { get; set; }
    }
}
