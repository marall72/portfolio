using System.Data.Entity;
using TodoList.Model;

namespace TodoList.Database
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext() : base("Default")
        {

        }

        public DbSet<Todo> Todo { get; set; }
    }
}
