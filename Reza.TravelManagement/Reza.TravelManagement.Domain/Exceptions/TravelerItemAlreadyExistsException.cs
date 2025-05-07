using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Domain.Exceptions
{
    internal class TravelerItemAlreadyExistsException:TravelerCheckListException
    {
        public string ListName { get;}
        public string ItemName { get; set; }

        public TravelerItemAlreadyExistsException(string listName,string itemName)
            :base($"Traveler Check List: '{listName}' already defined item '{itemName}'")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
