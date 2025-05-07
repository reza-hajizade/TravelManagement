using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Domain.Exceptions
{
    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; }

        public TravelerItemNotFoundException(string itemName) : base($"Traveler item '{itemName}' Not Found")
        {
            ItemName = itemName;
        }
    }
}
