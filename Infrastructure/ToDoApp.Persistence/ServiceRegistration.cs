using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Persistence.Context;
using ToDoApp.Persistence.Repositories;

namespace ToDoApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(@"Data Source=.; Initial Catalog=ToDoApp; Integrated security =true;"));

            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
