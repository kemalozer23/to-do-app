using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Persistence.Context;

namespace ToDoApp.Persistence.Repositories
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public TaskRepository(ToDoDbContext toDoDbContext)
        : base(toDoDbContext)
        {
        }

    }
}
