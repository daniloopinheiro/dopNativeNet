using dopNN.Domain.Enums;
using dopNN.Domain.ValueObjects;

namespace dopNN.Domain.Entities
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public Temperature Temperature { get; set; }

        public WeatherCondition Condition { get; set; }

        public string? Summary { get; set; }

        public WeatherForecast(DateOnly date, Temperature temperature, WeatherCondition condition, string? summary = null)
        {
            Date = date;
            Temperature = temperature;
            Condition = condition;
            Summary = summary;
        }
    }
}
