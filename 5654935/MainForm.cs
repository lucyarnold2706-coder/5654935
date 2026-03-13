using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string location = cmbLocation.SelectedItem.ToString();
            string weatherData = await GetWeatherData(location);
            lblWeatherDisplay.Text = weatherData;
        }

        private async Task<string> GetWeatherData(string location)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync($"https://api.weatherapi.com/v1/current.json?key=YOUR_API_KEY&q={location}");
                    return response;
                }
                catch (Exception ex)
                {
                    return $"Error retrieving weather data: {ex.Message}";
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbLocation.Items.AddRange(new string[] { "Mannheim", "Berlin", "Zugspitze" });
        }
    }
}