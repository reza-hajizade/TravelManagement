using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.Entities;
using Reza.TravelManagement.Domain.ValueObjects;
using Reza.TravelManagement.Shared.Abstractions.Domain;

namespace Reza.TravelManagement.Domain.Events
{
    public record TravelerItemTaken(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;


}
