using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Domain.Exceptions
{
    public class TravelerItemNameException : TravelerCheckListException
    {
        public TravelerItemNameException() : base("Traveler item name cannot be empty")
        {
        }
    }
   
}
