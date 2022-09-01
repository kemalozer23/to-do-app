using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Features.AddCategory;
using ToDoApp.Application.Features.AddTask;

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

        [HttpPost]
        public async Task AddTask([FromQuery] AddCategoryCommandRequest request)
        {
            await _mediator.Send(request);
        }
    }
}
