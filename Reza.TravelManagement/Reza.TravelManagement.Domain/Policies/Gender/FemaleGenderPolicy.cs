using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Policies.Gender
{
    internal class FemaleGenderPolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Female;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
        => new List<TravelerItem>
        {
            new("Lipstick", 1),
            new("Powder", 1),
            new("Eyeliner", 1)
        };



    }
}
