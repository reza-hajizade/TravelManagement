using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands
{
    public record TakeItem(Guid TravelerCheckListId, string Name) : ICommand;
}
