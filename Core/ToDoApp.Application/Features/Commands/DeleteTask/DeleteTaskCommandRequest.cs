﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Features.Commands.DeleteTask
{
    public class DeleteTaskCommandRequest : IRequest<DeleteTaskCommandResponse>
    {
        public int Id { get; set; }
    }
}
