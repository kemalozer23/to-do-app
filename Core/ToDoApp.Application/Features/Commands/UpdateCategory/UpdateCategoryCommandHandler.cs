using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        private readonly IRepositoryManager _repository;

        public UpdateCategoryCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = _repository.Category.FindByCondition(x => x.Id == request.Id, true).First();

            category.Name = request.Name;

            _repository.Category.Update(category);
            _repository.Save();

            return new();
        }
    }
}
