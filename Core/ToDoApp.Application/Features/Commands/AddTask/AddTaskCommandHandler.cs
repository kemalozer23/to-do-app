using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Features.Commands.AddTask
{
    public class AddTaskCommandHandler : IRequestHandler<AddTaskCommandRequest, AddTaskCommandResponse>
    {
        private readonly IRepositoryManager _repository;

        public AddTaskCommandHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<AddTaskCommandResponse> Handle(AddTaskCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Task task = new();

            task.Description = request.Description;

            var categoryExists = _repository.Category.FindAll(true).Select(x => x.Name).Contains(request.CategoryName);
            if (categoryExists == false)
            {
                Category category = new();
                category.Name = request.CategoryName;
                _repository.Category.Create(category);
                _repository.Save();
            }
            var categoryId = _repository.Category.FindAll(true).Where(x => x.Name == request.CategoryName).Select(x => x.Id).First();
            task.CategoryId = categoryId;

            _repository.Task.Create(task);
            _repository.Save();

            return new();
        }
    }
}
