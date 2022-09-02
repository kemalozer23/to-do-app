using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Features.Commands.AddCategory;
using ToDoApp.Application.Features.Queries.GetAllCategories;

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
        public async Task AddCategory([FromQuery] AddCategoryCommandRequest request)
        {
            await _mediator.Send(request);
        }

        [HttpGet]
        public async Task<GetAllCategoriesQueryResponse> GetAllCategories([FromQuery] GetAllCategoriesQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
