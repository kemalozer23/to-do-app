using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Features.AddTask;

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
    }
}
