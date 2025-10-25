using AutoMapper;
using TodoList.Database;
using TodoList.Mapping;

namespace TodoList.Business
{
    public class BusinessBase
    {
        public BusinessBase(TodoDbContext todoDbContext, LogDbContext logDbContext, AutoMapper.IConfigurationProvider config)
        {
            TodoDbContext = todoDbContext;
            LogDbContext = logDbContext;
            Mapper = config.CreateMapper();
        }

        public TodoDbContext TodoDbContext { get; set; }
        public LogDbContext LogDbContext { get; set; }
        public IMapper Mapper { get; set;}
    }
}
