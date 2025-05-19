using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Domain.ValueObjects;
using Reza.TravelManagement.Shared.Abstractions.Exceptions;

namespace Reza.TravelManagement.Application.Exceptions
{
    internal class MissingDestinationWeatherException:TravelerCheckListException
    {
        public Destination Destination { get; }

        public MissingDestinationWeatherException(Destination destination)
            : base($"Couldn't fetch weather data for Destination '{destination.Country}/{destination.City}'.")
        {
            Destination = destination;
        }
    }
}
