// WeatherDatabase.cs

using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherEntry
    {
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public double Temperature { get; set; }
        public double AirPressure { get; set; }
    }

    public class WeatherDatabase
    {
        public List<WeatherEntry> WeatherEntries { get; set; }

        public WeatherDatabase()
        {
            WeatherEntries = new List<WeatherEntry>();
            PopulateData();
        }

        private void PopulateData()
        {
            // February 2024 Weather Data
            WeatherEntries.Add(new WeatherEntry { Timestamp = new DateTime(2024, 2, 1, 0, 0, 0), Location = "Mannheim", Temperature = 3.5, AirPressure = 1022 });
            WeatherEntries.Add(new WeatherEntry { Timestamp = new DateTime(2024, 2, 1, 0, 0, 0), Location = "Berlin", Temperature = 2.0, AirPressure = 1018 });
            WeatherEntries.Add(new WeatherEntry { Timestamp = new DateTime(2024, 2, 1, 0, 0, 0), Location = "Zugspitze", Temperature = -5.0, AirPressure = 1000 });
            // Add more entries for February...

            // March 2024 Weather Data
            WeatherEntries.Add(new WeatherEntry { Timestamp = new DateTime(2024, 3, 1, 0, 0, 0), Location = "Mannheim", Temperature = 8.0, AirPressure = 1015 });
            WeatherEntries.Add(new WeatherEntry { Timestamp = new DateTime(2024, 3, 1, 0, 0, 0), Location = "Berlin", Temperature = 6.5, AirPressure = 1012 });
            WeatherEntries.Add(new WeatherEntry { Timestamp = new DateTime(2024, 3, 1, 0, 0, 0), Location = "Zugspitze", Temperature = -3.0, AirPressure = 990 });
            // Add more entries for March...
        }
    }
}