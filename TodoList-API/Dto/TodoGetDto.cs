using TodoList.Enum;

namespace TodoList.Dto
{
    public class TodoGetDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public TodoStatus Status { get; set; }
        public string StatusTitle { get; set; }
    }
}
