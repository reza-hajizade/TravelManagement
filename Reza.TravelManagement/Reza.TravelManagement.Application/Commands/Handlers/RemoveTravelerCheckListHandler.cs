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
    public class RemoveTravelerCheckListHandler : ICommandHandler<RemoveTravelerCheckList>
    {
        private readonly ITravelerCheckListRepository _travelerCheckListRepository;
        public RemoveTravelerCheckListHandler(ITravelerCheckListRepository travelerCheckListRepository)
        {
            _travelerCheckListRepository = travelerCheckListRepository;
        }
        public async Task HandleAsync(RemoveTravelerCheckList command)
        {
            var TravelerCheckList=await _travelerCheckListRepository .GetAsync(command.Id);

            if (TravelerCheckList is null)
            {
                throw new TravelerCheckListNotFound(command.Id);
            }

           await _travelerCheckListRepository.DeleteAsync(TravelerCheckList);

        }
    }
}
