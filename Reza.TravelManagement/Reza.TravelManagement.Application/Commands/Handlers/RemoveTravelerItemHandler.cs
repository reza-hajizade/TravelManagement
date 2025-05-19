using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reza.TravelManagement.Application.Exceptions;
using Reza.TravelManagement.Domain.Repositories;
using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands.Handlers
{
    public class RemoveTravelerItemHandler : ICommandHandler<RemoveTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public RemoveTravelerItemHandler(ITravelerCheckListRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(RemoveTravelerItem command)
        {
            var travelerCheckingList =await _repository.GetAsync(command.TravelerCheckListId);

            if(travelerCheckingList == null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }
           await _repository.DeleteAsync(travelerCheckingList);
        }
    }
}
