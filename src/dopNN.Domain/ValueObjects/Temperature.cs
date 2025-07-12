using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopNN.Domain.ValueObjects
{
    public readonly struct Temperature
    {
        public int Celsius { get; }
        public int Fahrenheit => 32 + (int)(Celsius / 0.5556);

        public Temperature(int celsius)
        {
            Celsius = celsius;
        }

        public override string ToString() => $"{Celsius}°C / {Fahrenheit}°F";
    }
}
