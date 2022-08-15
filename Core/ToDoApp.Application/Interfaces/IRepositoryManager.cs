using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Interfaces
{
    public interface IRepositoryManager
    {
        ITaskRepository Task { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
