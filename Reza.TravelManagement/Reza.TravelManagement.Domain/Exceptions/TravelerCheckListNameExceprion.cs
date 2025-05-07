using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Domain.Exceptions
{
    public class TravelerCheckListNameExceprion:TravelerCheckListException
    {
        public TravelerCheckListNameExceprion() : base("Traveler checkList list name cannot be empty")
        {
        }
    }
}
