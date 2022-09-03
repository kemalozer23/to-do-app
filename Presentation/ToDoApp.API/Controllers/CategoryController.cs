using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Features.Commands.AddCategory;
using ToDoApp.Application.Features.Commands.DeleteCategory;
using ToDoApp.Application.Features.Commands.DeleteTask;
using ToDoApp.Application.Features.Commands.UpdateCategory;
using ToDoApp.Application.Features.Commands.UpdateTask;
using ToDoApp.Application.Features.Queries.GetAllCategories;
using ToDoApp.Application.Features.Queries.GetCategoryByCondition;
using ToDoApp.Application.Features.Queries.GetTaskByCondition;

namespace ToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddCategory")]
        public async Task AddCategory([FromQuery] AddCategoryCommandRequest request)
        {
            await _mediator.Send(request);
        }

        [HttpGet("GetAllCategories")]
        public async Task<GetAllCategoriesQueryResponse> GetAllCategories([FromQuery] GetAllCategoriesQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("GetCategoryById")]
        public async Task<GetCategoryByIdQueryResponse> GetCategoryById([FromQuery] GetCategoryByIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPut("UpdateCategory")]
        public async Task UpdateCategory([FromQuery] UpdateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
        }

        [HttpDelete("DeleteCategory")]
        public async Task DeleteCategory([FromQuery] DeleteCategoryCommandRequest request)
        {
            await _mediator.Send(request);
        }
    }
}
