using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.Commands.UpdateTask
{
    public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommandRequest, UpdateTaskCommandResponse>
    {
        private readonly IRepositoryManager _repository;

        public UpdateTaskCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<UpdateTaskCommandResponse> Handle(UpdateTaskCommandRequest request, CancellationToken cancellationToken)
        {
            var task = _repository.Task.FindByCondition(x => x.Id == request.Id, true).First();
            task.IsComplete = request.IsComplete;
            task.Description = request.Description;

            _repository.Task.Update(task);
            _repository.Save();

            return new();
        }
    }
}
