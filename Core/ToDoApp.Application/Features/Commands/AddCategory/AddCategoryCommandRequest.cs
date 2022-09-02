using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Commands.AddCategory
{
    public class AddCategoryCommandRequest : IRequest<AddCategoryCommandResponse>
    {
        public string? Name { get; set; }
    }
}
