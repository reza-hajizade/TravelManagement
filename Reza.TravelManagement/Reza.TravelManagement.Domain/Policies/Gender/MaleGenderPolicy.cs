﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Policies.Gender
{
    public class MaleGenderPolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data)
       => data.Gender is Consts.Gender.Male;

        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
          => new List<TravelerItem>
          {
                new("Laptop", 1),
                new("Drink", 10),
                new("Book", (uint) Math.Ceiling(data.Days/7m)),
          };
    }

}
