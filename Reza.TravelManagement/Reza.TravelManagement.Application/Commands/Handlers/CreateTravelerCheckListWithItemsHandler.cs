using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reza.TravelManagement.Application.Exceptions;
using Reza.TravelManagement.Application.Services;
using Reza.TravelManagement.Domain.Factories;
using Reza.TravelManagement.Domain.Repositories;
using Reza.TravelManagement.Domain.ValueObjects;
using Reza.TravelManagement.Shared.Abstractions.Commands;

namespace Reza.TravelManagement.Application.Commands.Handlers
{
    public class CreateTravelerCheckListWithItemsHandler : ICommandHandler<CreateTravelerCheckListWithItems>
    {
        private readonly ITravelerCheckListRepository _repository;
        private readonly ITravelerCheckListFactory _factory;
        private readonly IWeatherService _weatherService;



        public CreateTravelerCheckListWithItemsHandler(ITravelerCheckListRepository repository, ITravelerCheckListFactory factory,
            IWeatherService weatherService)
        {
            _repository = repository;
            _factory = factory;
            _weatherService = weatherService;
        }

        public async Task HandleAsync(CreateTravelerCheckListWithItems command)
        {
            var (id, name, days, gender, DestinationWriteModel) = command;
         

            var destination = new Destination(DestinationWriteModel.City, DestinationWriteModel.Country);
            var weather = await _weatherService.GetWeatherAsync(destination);

            if (weather is null)
            {
                throw new MissingDestinationWeatherException(destination);
            }

            var TravelerCheckList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.Temperature,
                destination);

            await _repository.AddAsync(TravelerCheckList);
        }
}
