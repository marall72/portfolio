using TodoList.Database;
using TodoList.Model;

namespace TodoList.Business
{
    public class TodoListBusiness : BusinessBase
    {
        public TodoListBusiness(TodoDbContext db) : base(db)
        {
            
        }

        public void Insert(Todo model)
        {

        }
    }
}
