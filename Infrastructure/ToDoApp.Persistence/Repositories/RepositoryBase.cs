using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Persistence.Context;

namespace ToDoApp.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ToDoDbContext ToDoDbContext;

        public RepositoryBase(ToDoDbContext toDoDbContext)
        {
            ToDoDbContext = toDoDbContext;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
             !trackChanges ?
             ToDoDbContext.Set<T>()
             .AsNoTracking() :
             ToDoDbContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
            !trackChanges ?
            ToDoDbContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
            ToDoDbContext.Set<T>()
            .Where(expression);
        public void Create(T entity) => ToDoDbContext.Set<T>().Add(entity);
        public void Update(T entity) => ToDoDbContext.Set<T>().Update(entity);
        public void Delete(T entity) => ToDoDbContext.Set<T>().Remove(entity);
    }
}
