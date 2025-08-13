using System.Threading.Tasks;
using TodoList.Database;
using TodoList.Model;
using Microsoft.EntityFrameworkCore;


namespace TodoList.Business
{
    public class LogBusiness
    {
        private LogDbContext LogDbContext { get; set; }
        public LogBusiness(LogDbContext logDbContext)
        {
            LogDbContext = logDbContext;
        }

        public async Task Insert(Log log)
        {
            LogDbContext.Logs.Add(log);
            await LogDbContext.SaveChangesAsync();
        }
    }
}
