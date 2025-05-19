using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands
{
    public record RemoveTravelerItem(Guid TravelerCheckListId, string Name) : ICommand;

}
