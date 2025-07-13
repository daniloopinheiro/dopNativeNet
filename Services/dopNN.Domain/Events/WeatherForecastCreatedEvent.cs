using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopNN.Domain.Events
{
    public record WeatherForecastCreatedEvent(DateOnly Date, int TemperatureC, string? Summary);
}
