﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Policies.Temperature
{
    internal sealed class HighTemperaturePolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data)
            => data.Temperature > 25D;

        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
            {
                new("Hat", 1),
                new("Sunglasses", 1),
                new("Cream with UV filter", 1)
            };
    }
}
