﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.Exceptions;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Domain.ValueObjects
{
    public record TravelerItem
    {
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }

        public TravelerItem(string name,uint quantity,bool isTaken=false)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new TravelerItemNameException();

            Name = name;
            Quantity = quantity;
            IsTaken = isTaken;
        }


    }
}
