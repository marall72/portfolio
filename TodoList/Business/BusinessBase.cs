using TodoList.Database;

namespace TodoList.Business
{
    public class BusinessBase
    {
        public BusinessBase(TodoDbContext todoDbContext)
        {
            TodoDbContext = todoDbContext;
        }

        public TodoDbContext TodoDbContext { get; set; }
    }
}
