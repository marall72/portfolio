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
        public async Task InsertAsync(TodoInsertDto model)
        {
            var converted = Mapper.Map<Todo>(model);
            converted.CreateDate = DateTime.Now;
            converted.UpdateDate = DateTime.Now;
            converted.Status = Enum.TodoStatus.Created;
            TodoDbContext.Todos.Add(converted);
            await TodoDbContext.SaveChangesAsync();
        }

        public async Task<TodoGetDto> GetAsync(int id)
        {
            var result = await TodoDbContext.Todos.FirstOrDefaultAsync(x => x.Id == id);
            return Mapper.Map<Todo, TodoGetDto>(result);
        }

        public async Task<List<TodoGetDto>> GetAsync(TodoCriteria criteria)
        {
            var result = await TodoDbContext.Todos.Where(x => criteria.SearchText.Contains(x.Title) || criteria.SearchText.Contains(x.Description) || string.IsNullOrEmpty(criteria.SearchText)).ToListAsync();

            return Mapper.Map<List<Todo>, List<TodoGetDto>>(result);
        }

        public async Task DeleteAsync(int id)
        {
            var model = await TodoDbContext.Todos.FirstOrDefaultAsync(x=> x.Id == id);
            if (model != null)
            {
                TodoDbContext.Todos.Remove(model);
                await TodoDbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(TodoUpdateDto model)
        {
            var original = TodoDbContext.Todos.FirstOrDefault(x=> x.Id == model.Id);
            if(original != null) {

                original.UpdateDate = DateTime.Now;
                original.Title = model.Title;
                original.Description = model.Description;
                original.Status = model.Status;
                await TodoDbContext.SaveChangesAsync();
            }
        }
    }
}
