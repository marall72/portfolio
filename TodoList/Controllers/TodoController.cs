using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using TodoList.Business;
using TodoList.Dto;

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

        [HttpPost("/add")]
        public async Task<IActionResult> Add(TodoInsertDto model)
        {
            await _todoListBusiness.Insert(model);
            return Ok();
        }
    }
}
