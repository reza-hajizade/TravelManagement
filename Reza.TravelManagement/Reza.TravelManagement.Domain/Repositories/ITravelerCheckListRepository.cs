using Reza.TravelManagement.Domain.Entities;
using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Repositories
{
    public interface ITravelerCheckListRepository
    {
        Task<TravelerCheckList> GetAsync(TravelerCheckListId id);
        Task AddAsync(TravelerCheckList travelerCheckList);
        Task UpdateAsync(TravelerCheckList travelerCheckList);
        Task DeleteAsync(TravelerCheckList travelerCheckList);
    }
}
