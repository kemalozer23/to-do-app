using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, GetAllCategoriesQueryResponse>
    {
        public readonly IRepositoryManager _repository;

        public GetAllCategoriesQueryHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<GetAllCategoriesQueryResponse> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var names = _repository.Category.FindAll(true).Select(x => x.Name).ToList();

            return new()
            {
                Names = names
            };
        }
    }
}
