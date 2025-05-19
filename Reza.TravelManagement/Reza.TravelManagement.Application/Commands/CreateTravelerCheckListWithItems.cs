using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.Consts;
using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands 
{
    public record CreateTravelerCheckListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
       DestinationWriteModel Destionation) : ICommand;

    public record DestinationWriteModel(string City, string Country);
}
