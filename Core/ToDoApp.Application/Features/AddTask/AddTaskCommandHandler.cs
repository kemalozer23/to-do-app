using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.Application.Features.AddTask
{
    public class AddTaskCommandHandler : IRequestHandler<AddTaskCommandRequest, AddTaskCommandResponse>
    {
        readonly IRepositoryManager _repository;

        public AddTaskCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<AddTaskCommandResponse> Handle(AddTaskCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Task task = new();

            task.Description = request.Description;
            task.Category.Name = request.CategoryName;

            _repository.Task.CreateTask(task);
            _repository.Save();

            return new();
        }
    }
}
