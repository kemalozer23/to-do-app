using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Commands.DeleteTask
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommandRequest, DeleteTaskCommandResponse>
    {
        public readonly IRepositoryManager _repository;

        public DeleteTaskCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<DeleteTaskCommandResponse> Handle(DeleteTaskCommandRequest request, CancellationToken cancellationToken)
        {
            var task = _repository.Task.FindByCondition(x => x.Id == request.Id, true).First();

            _repository.Task.Delete(task);
            _repository.Save();

            return new();
        }
    }
}
