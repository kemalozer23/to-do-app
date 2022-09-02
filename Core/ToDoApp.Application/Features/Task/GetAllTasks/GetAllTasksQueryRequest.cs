using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.GetTask
{
    public class GetAllTasksQueryRequest : IRequest<GetAllTasksQueryResponse>
    {
    }
}
