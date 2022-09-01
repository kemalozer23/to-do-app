using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Common;

namespace ToDoApp.Domain.Entities
{
    public class Task : BaseEntity
    {
        public string? Description { get; set; }
        public bool IsComplete { get; set; } = false;

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
