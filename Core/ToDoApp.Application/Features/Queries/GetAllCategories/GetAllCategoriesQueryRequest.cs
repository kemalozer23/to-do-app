using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryRequest : IRequest<GetAllCategoriesQueryResponse>
    {
        public bool Test { get; set; } = true;
    }
}
