using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Queries.GetAllTasks
{
    public class GetAllTasksQueryRequest : IRequest<GetAllTasksQueryResponse>
    {
        public bool Test { get; set; } = true;
    }
}
