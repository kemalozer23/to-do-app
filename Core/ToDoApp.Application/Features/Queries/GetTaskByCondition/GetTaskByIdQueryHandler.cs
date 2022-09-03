using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Queries.GetTaskByCondition
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQueryRequest, GetTaskByIdQueryResponse>
    {
        private readonly IRepositoryManager _repository;

        public GetTaskByIdQueryHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<GetTaskByIdQueryResponse> Handle(GetTaskByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var task = _repository.Task.FindByCondition(x => x.Id == request.Id, true).First();
            var categoryName = _repository.Category.FindByCondition(x => x.Id == task.CategoryId, true).Select(c => c.Name).First();

            return new()
            {
                Description = task.Description,
                IsComplete = task.IsComplete,
                CategoryName = categoryName
            };
        }
    }
}
