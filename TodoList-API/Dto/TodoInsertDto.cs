using System.ComponentModel.DataAnnotations;

namespace TodoList.Dto
{
    public class TodoInsertDto
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; } = "";
    }
}
