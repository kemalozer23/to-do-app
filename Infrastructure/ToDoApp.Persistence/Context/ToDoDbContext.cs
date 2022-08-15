using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain.Entities;
using Task = ToDoApp.Domain.Entities.Task;

namespace ToDoApp.Persistence.Context
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Task>? Tasks { get; set; }
    }
}
