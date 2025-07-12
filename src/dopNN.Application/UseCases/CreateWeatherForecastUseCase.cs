using dopNN.Domain.Enums;
using dopNN.Domain.Entities;
using dopNN.Application.DTOs;
using dopNN.Domain.Interfaces;
using dopNN.Domain.ValueObjects;

namespace dopNN.Application.UseCases
{
    public class CreateWeatherForecastUseCase
    {
        private readonly IWeatherService _service;

        public CreateWeatherForecastUseCase(IWeatherService service)
        {
            _service = service;
        }

        public async Task ExecuteAsync(WeatherForecastDto dto)
        {
            var temperature = new Temperature(dto.TemperatureCelsius);
            var forecast = new WeatherForecast(dto.Date, temperature, dto.Condition, dto.Summary);

            await _service.CreateForecastAsync(forecast);
        }
    }
}
