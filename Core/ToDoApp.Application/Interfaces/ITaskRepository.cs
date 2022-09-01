using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Features;

namespace ToDoApp.Application.Interfaces
{
    public interface ITaskRepository
    {
        void CreateTask(Domain.Entities.Task task);
    }
}
