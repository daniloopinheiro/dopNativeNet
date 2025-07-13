using dopNN.Domain.Entities;

namespace dopNN.Domain.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateOnly startDate, int days);
        Task CreateForecastAsync(WeatherForecast forecast);
    }
}
