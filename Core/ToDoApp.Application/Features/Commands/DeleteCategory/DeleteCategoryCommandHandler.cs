using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly IRepositoryManager _repository;

        public DeleteCategoryCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = _repository.Category.FindByCondition(x => x.Id == request.Id, true).First();

            _repository.Category.Delete(category);
            _repository.Save();

            return new();
        }
    }
}
