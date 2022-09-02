using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Queries.GetTaskByCondition
{
    public class GetTaskByIdQueryRequest : IRequest<GetTaskByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
