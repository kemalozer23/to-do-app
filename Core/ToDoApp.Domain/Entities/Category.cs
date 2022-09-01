using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Common;

namespace ToDoApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        public IEnumerable<Task>? Tasks { get; set; }
    }
}
