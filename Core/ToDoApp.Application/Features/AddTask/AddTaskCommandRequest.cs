using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Features.AddTask
{
    public class AddTaskCommandRequest : IRequest<AddTaskCommandResponse>
    {
        public string? Description { get; set; }
        public string CategoryName { get; set; }
    }
}
