using Reza.TravelManagement.Domain.Consts;
using Reza.TravelManagement.Domain.Entities;
using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);

        TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id,TravelerCheckListName name, TravelDays days 
            ,Gender gender, Temperature temperature, Destination destination);

    }
}
