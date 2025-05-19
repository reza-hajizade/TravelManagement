using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Application.Exceptions;
using Reza.TravelManagement.Domain.Repositories;
using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands.Handlers
{
    public sealed class TakeItemHandler : ICommandHandler<TakeItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public TakeItemHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(TakeItem command)
        {
            var TravelerCheckList = await _repository.GetAsync(command.TravelerCheckListId);

            if (TravelerCheckList is null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }

            TravelerCheckList.TakeItem(command.Name);

            await _repository.UpdateAsync(TravelerCheckList);
        }
    }
}
