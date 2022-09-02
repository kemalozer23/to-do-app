using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Commands.UpdateTask
{
    public class UpdateTaskCommandRequest : IRequest<UpdateTaskCommandResponse>
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; } = false;
    }
}
