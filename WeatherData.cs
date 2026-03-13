using System;

namespace WeatherApp
{
    public class WeatherData
    {
        public string Location { get; set; }
        public float Temperature { get; set; }
        public float AirPressure { get; set; }
        public DateTime DateTime { get; set; }

        public WeatherData(string location, float temperature, float airPressure, DateTime dateTime)
        {
            Location = location;
            Temperature = temperature;
            AirPressure = airPressure;
            DateTime = dateTime;
        }
    }
}