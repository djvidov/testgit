using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursePrepation
{
    public class Celsius : ITemperature
    {
        public Celsius(float temp)
        {
            Degrees = temp;
        }

        public Celsius(Fahrenheit fahrenheit)
        {
            Degrees = (5.0f / 9.0f) * (fahrenheit.Degrees - 32);
        }

        public float Degrees { get; }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit((9.0f / 5.0f) * celsius.Degrees + 32);
        }
    }

    public class Fahrenheit: ITemperature
    {
        public Fahrenheit(float temp)
        {
            Degrees = temp;
        }

        public Fahrenheit(Celsius celsius)
        {
            Degrees = (9.0f / 5.0f) * celsius.Degrees + 32;
        }

        public float Degrees { get; }

        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((5.0f / 9.0f) * (fahr.Degrees - 32));
        }
    }
}
