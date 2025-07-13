using dopNN.Domain.Enums;

namespace dopNN.Application.DTOs
{
    public class WeatherForecastDto
    {
        public DateOnly Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public WeatherCondition Condition { get; set; }
        public string? Summary { get; set; }
    }
}
