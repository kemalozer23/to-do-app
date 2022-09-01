using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Features;
using ToDoApp.Application.Interfaces;
using ToDoApp.Persistence.Context;

namespace ToDoApp.Persistence.Repositories
{
    public class TaskRepository : RepositoryBase<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(ToDoDbContext toDoDbContext)
        : base(toDoDbContext)
        {
        }

        public void CreateTask(Domain.Entities.Task task)
        {
            Create(task);
        }
    }
}
