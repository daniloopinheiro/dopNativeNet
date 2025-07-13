using dopNN.Application.DTOs;
using dopNN.Domain.Entities;

namespace dopNN.Application.Interface
{
    public interface IWeatherForecast
    {
        Task AddAsync(WeatherForecast forecast);
        Task<IEnumerable<WeatherForecast>> GetAll();
        Task SeedMockDataAsync();
        Task<IEnumerable<WeatherForecast>> GetAllAsync(WeatherForecastDto dto);
    }
}
