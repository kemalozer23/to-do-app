using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Persistence.Context;

namespace ToDoApp.Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly ToDoDbContext _toDoDbContext;
        private readonly Lazy<ITaskRepository> _taskRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;

        public RepositoryManager(ToDoDbContext toDoDbContext)
        {
            _toDoDbContext = toDoDbContext;
            _taskRepository = new Lazy<ITaskRepository>(() => new TaskRepository(toDoDbContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(toDoDbContext));
        }

        public ITaskRepository Task => _taskRepository.Value;
        public ICategoryRepository Category => _categoryRepository.Value;

        public void Save() => _toDoDbContext.SaveChanges(); 
    }
}
