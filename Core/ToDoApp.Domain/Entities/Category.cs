using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Common;

namespace ToDoApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public IEnumerable<Task>? Tasks { get; set; }
    }
}
