using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using TodoList.Business;
using TodoList.Criteria;
using TodoList.Dto;
using TodoList.Model;

namespace TodoList.Controllers
{
    //TODO: add try catch and logging
    [Route("todo")]
    public class TodoController : Controller
    {
        private TodoListBusiness _todoListBusiness;

        public TodoController(TodoListBusiness todoListBusiness)
        {
            _todoListBusiness = todoListBusiness;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] TodoInsertDto model)
        {
            await _todoListBusiness.InsertAsync(model);
            return Ok();
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] TodoUpdateDto model)
        {
            await _todoListBusiness.UpdateAsync(model);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<TodoGetDto> GetAsync(int id)
        {
            var result = await _todoListBusiness.GetAsync(id);
            return result;
        }

        [HttpGet("list")]
        public async Task<List<TodoGetDto>> GetListAsync(TodoCriteria criteria)
        {
            var result = await _todoListBusiness.GetAsync(criteria);
            return result;
        }

        [HttpGet("delete")]
        public async Task<IActionResult> GetListAsync(int id)
        {
            await _todoListBusiness.DeleteAsync(id);
            return Ok();
        }
    }
}
