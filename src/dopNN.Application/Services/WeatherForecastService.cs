using dopNN.Application.DTOs;
using dopNN.Application.Extensions;
using dopNN.Application.Interface;
using dopNN.Domain.Entities;
using dopNN.Domain.Enums;
using dopNN.Domain.ValueObjects;
using System.Collections.Generic;

namespace dopNN.Application.Services
{
    public class WeatherForecastService : IWeatherForecast
    {
        private readonly List<WeatherForecast> _forecasts = new();

        public Task AddAsync(WeatherForecast forecast)
        {
            _forecasts.Add(forecast);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<WeatherForecast>> GetAllAsync(WeatherForecastDto dto)
        {
            var temperature = new Temperature(dto.TemperatureCelsius);
            var entity = new WeatherForecast(dto.Date, temperature, dto.Condition, dto.Summary);
            _forecasts.Add(entity);
            return Task.FromResult<IEnumerable<WeatherForecast>>(_forecasts);
        }

        public Task<IEnumerable<WeatherForecast>> GetAll()
        {
            return Task.FromResult<IEnumerable<WeatherForecast>>(_forecasts);
        }

        public Task SeedMockDataAsync()
        {
            var mocks = new List<WeatherForecastDto>
            {
                new WeatherForecastDto
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                    TemperatureCelsius = 25,
                    Condition = WeatherCondition.Sunny,
                    Summary = "Céu limpo e ensolarado"
                },
                new WeatherForecastDto
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)),
                    TemperatureCelsius = 18,
                    Condition = WeatherCondition.Cloudy,
                    Summary = "Nublado com chance de chuva"
                },
                new WeatherForecastDto
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)),
                    TemperatureCelsius = 12,
                    Condition = WeatherCondition.Rainy,
                    Summary = "Chuva o dia inteiro"
                }
            };

            _forecasts.AddRange(mocks.Select(dto => dto.ToEntity()));
            return Task.CompletedTask;
        }
    }
}
