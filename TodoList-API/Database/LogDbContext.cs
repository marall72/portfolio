using Microsoft.EntityFrameworkCore;
using TodoList.Model;

namespace TodoList.Database
{
    public class LogDbContext : DbContext
    {
        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
        {
                
        }

        public DbSet<Log> Logs { get; set; }
    }
}
