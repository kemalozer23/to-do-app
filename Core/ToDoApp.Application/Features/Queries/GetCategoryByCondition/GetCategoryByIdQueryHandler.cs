using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Queries.GetCategoryByCondition
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, GetCategoryByIdQueryResponse>
    {
        private readonly IRepositoryManager _repository;

        public GetCategoryByIdQueryHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResponse> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var categoryName = _repository.Category.FindByCondition(x => x.Id == request.Id, true).Select(c => c.Name).First();

            return new()
            {
                Name = categoryName
            };
        }
    }
}
