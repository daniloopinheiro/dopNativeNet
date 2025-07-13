using dopNN.Application.DTOs;
using dopNN.Domain.Entities;
using dopNN.Domain.ValueObjects;

namespace dopNN.Application.Extensions
{
    public static class WeatherForecastMapper
    {
        public static WeatherForecastDto ToDto(this WeatherForecast forecast)
        {
            return new WeatherForecastDto
            {
                Date = forecast.Date,
                TemperatureCelsius = forecast.Temperature.Celsius,
                Condition = forecast.Condition,
                Summary = forecast.Summary
            };
        }

        public static WeatherForecast ToEntity(this WeatherForecastDto dto)
        {
            return new WeatherForecast(
                dto.Date,
                new Temperature(dto.TemperatureCelsius),
                dto.Condition,
                dto.Summary
            );
        }
    }
}
