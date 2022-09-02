using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Queries.GetTaskByCondition
{
    public class GetTaskByIdQueryResponse
    {
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
        public string? CategoryName { get; set; }
    }
}
