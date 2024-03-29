﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Features.Queries.GetAllTasks;
using ToDoApp.Application.Interfaces;
using static ToDoApp.Application.Features.Queries.GetAllTasks.GetAllTasksQueryResponse;

namespace ToDoApp.Application.Features.Queries.GetAllTasks
{
    public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQueryRequest, GetAllTasksQueryResponse>
    {
        private readonly IRepositoryManager _repository;

        public GetAllTasksQueryHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<GetAllTasksQueryResponse> Handle(GetAllTasksQueryRequest request, CancellationToken cancellationToken)
        {
            List<TaskDto> taskDtos = new(); 
            var tasks = _repository.Task.FindAll(true).ToList(); 
            foreach (var task in tasks)
            {
                TaskDto taskDto = new TaskDto();
                taskDto.Description = task.Description;
                taskDto.IsComplete = task.IsComplete;
                var categoryName = _repository.Category.FindByCondition(x => x.Id == task.CategoryId, true).Select(x => x.Name).First();
                taskDto.CategoryName = categoryName;

                taskDtos.Add(taskDto);
            }

            return new()
            {
                Tasks = taskDtos,
            };
        }
    }
}
