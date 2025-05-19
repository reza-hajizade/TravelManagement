using Reza.TravelManagement.Application.DTO.External;
using Reza.TravelManagement.Domain.ValueObjects;

namespace Reza.TravelManagement.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Destination destination);
    }
}
