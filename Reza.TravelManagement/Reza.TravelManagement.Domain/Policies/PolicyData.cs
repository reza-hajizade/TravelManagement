using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObjects.Temperature Temperature,
       Destination Destination);
}
