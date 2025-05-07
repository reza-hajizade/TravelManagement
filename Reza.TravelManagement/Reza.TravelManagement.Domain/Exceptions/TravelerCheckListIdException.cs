using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Domain.Exceptions
{
    public class TravelerCheckListIdException:TravelerCheckListException
    {
        public TravelerCheckListIdException():base("Traveler CheckList Id cannot be empty")
        {
            
        }
    }
}
