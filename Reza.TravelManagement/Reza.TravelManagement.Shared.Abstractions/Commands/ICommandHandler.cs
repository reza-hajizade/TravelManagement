﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reza.TravelManagement.Shared.Abstractions.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand :class,ICommand
    {
        Task HandleAsync(TCommand command);
    }
}
