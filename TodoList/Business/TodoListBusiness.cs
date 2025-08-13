using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoList.Criteria;
using TodoList.Database;
using TodoList.Dto;
using TodoList.Mapping;
using TodoList.Model;

namespace TodoList.Business
{
    public class TodoListBusiness : BusinessBase
    {
        public TodoListBusiness(TodoDbContext db, LogDbContext log, AutoMapper.IConfigurationProvider config) : base(db, log, config)
        {

        }
        //TODO: add try catch and logging
        public async Task Insert(TodoInsertDto model)
        {
            var converted = Mapper.Map<Todo>(model);
            converted.CreateDate = DateTime.Now;
            converted.UpdateDate = DateTime.Now;
            TodoDbContext.Todos.Add(converted);
            await TodoDbContext.SaveChangesAsync();
        }

        public async Task<Todo> Get(int id)
        {
            return await TodoDbContext.Todos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Todo>> Get(TodoCriteria criteria)
        {
            return await TodoDbContext.Todos.Where(x => criteria.SearchText.Contains(x.Title) || criteria.SearchText.Contains(x.Description)).ToListAsync();
        }

        public async Task Delete(int id)
        {
            var model = await Get(id);
            if (model != null)
            {
                TodoDbContext.Todos.Remove(model);
                await TodoDbContext.SaveChangesAsync();
            }
        }
    }
}
