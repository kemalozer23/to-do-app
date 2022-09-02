using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Features.Commands.AddTask;
using ToDoApp.Application.Features.Commands.DeleteTask;
using ToDoApp.Application.Features.Commands.UpdateTask;
using ToDoApp.Application.Features.Queries.GetAllTasks;
using ToDoApp.Application.Features.Queries.GetTaskByCondition;

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

        [HttpPost("AddTask")]
        public async Task AddTask([FromQuery] AddTaskCommandRequest request)
        {
            await _mediator.Send(request);
        }

        [HttpGet("GetAllTasks")]
        public async Task<GetAllTasksQueryResponse> GetAllTasks([FromQuery] GetAllTasksQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpGet("GetTaskById")]
        public async Task<GetTaskByIdQueryResponse> GetTaskById([FromQuery] GetTaskByIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPut("UpdateTask")]
        public async Task UpdateTask([FromQuery] UpdateTaskCommandRequest request)
        {
            await _mediator.Send(request);
        }

        [HttpDelete("DeleteTask")]
        public async Task DeleteTask([FromQuery] DeleteTaskCommandRequest request)
        {
            await _mediator.Send(request);
        }
    }
}
