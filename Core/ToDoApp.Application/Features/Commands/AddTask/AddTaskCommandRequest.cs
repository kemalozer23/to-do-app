using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Features.Commands.AddTask
{
    public class AddTaskCommandRequest : IRequest<AddTaskCommandResponse>
    {
        public string? Description { get; set; }

        //public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
