using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Domain.Policies
{
    public interface ITravelerItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<TravelerItem> GenerateItems(PolicyData data);
    }
}
