using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Application.Exceptions;
using Reza.TravelManagement.Domain.Repositories;
using Reza.TravelManagement.Domain.ValueObjects;
using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands.Handlers
{
    public class AddTravelerItemHandler : ICommandHandler<AddTravelerItem>
    {
        private readonly ITravelerCheckListRepository _travelerCheckListRepository;

        public AddTravelerItemHandler(ITravelerCheckListRepository travelerCheckListRepository)
        {
            _travelerCheckListRepository = travelerCheckListRepository;
        }

        public async Task HandleAsync(AddTravelerItem command)
        {

            var travelerCheckingList =await _travelerCheckListRepository.GetAsync(command.TravelerCheckListId);

            if (travelerCheckingList != null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }


            var newTravelerItem = new TravelerItem(command.Name, command.Quantity);
            travelerCheckingList.AddItem(newTravelerItem);

            await _travelerCheckListRepository.UpdateAsync(travelerCheckingList);
        }
    }
}
