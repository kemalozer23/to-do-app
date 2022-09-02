using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.GetTask
{
    public class GetAllTasksQueryResponse
    {
        public List<TaskDto> Tasks { get; set; }

        public class TaskDto
        {
            public string Description { get; set; }
            public bool IsComplete { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
