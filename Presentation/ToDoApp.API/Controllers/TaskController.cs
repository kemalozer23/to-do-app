using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Features.AddTask;
using ToDoApp.Application.Features.GetTask;

namespace ToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task AddTask([FromQuery] AddTaskCommandRequest request)
        {
            await _mediator.Send(request);
        }

        [HttpGet]
        public async Task<GetAllTasksQueryResponse> GetAllTasks([FromQuery] GetAllTasksQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
