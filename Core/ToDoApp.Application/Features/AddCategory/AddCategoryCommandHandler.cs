using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Features.AddCategory
{
    internal class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommandRequest, AddCategoryCommandResponse>
    {
        private readonly IRepositoryManager _repository;

        public AddCategoryCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<AddCategoryCommandResponse> Handle(AddCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category category = new();
            category.Name = request.Name;

            _repository.Category.CreateCategory(category);
            _repository.Save();

            return new();
        }
    }
}
