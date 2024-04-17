using MediatR;
using WeatherApp.Application.Weather.Current;
using WeatherApp.Application.Weather.Forecast;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Presentation
{
    public partial class WeatherFrm : Form
    {
        private readonly ISender _sender;

        public WeatherFrm(ISender sender)
        {
            _sender = sender;
            InitializeComponent();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async void BtSearch_Click(object sender, EventArgs e)
        {
            string units = MetricRb.Checked
                ? "metric"
                : "imperial";
            try
            {
                var response = await _sender.Send(
                new CurrentWeatherQuery(
                    CityTb.Text,
                    CountryCodeTb.Text,
                    units));


                if (response.IsSuccess)
                {
                    PopulateWeatherInfo(response.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateWeatherInfo(WeatherInfo weatherInfo)
        {
            ResultTb.Text = $"{weatherInfo.Location.city.ToUpper()}({weatherInfo.Location.countryCode.ToUpper()})\r\n" +
                    $"{weatherInfo.Date:MMM dd, yyyy}\r\n" +
                    $"> Weather: {weatherInfo.Description}.\r\n" +
                    $"> Temperature: {weatherInfo.Temperature}";
        }

        private async void ForecastBt_Click(object sender, EventArgs e)
        {
            string units = MetricRb.Checked
                ? "metric"
                : "imperial";
            try
            {
                var response = await _sender.Send(
                new ForecastWeatherQuery(
                    CityTb.Text,
                    CountryCodeTb.Text,
                    units,
                    Convert.ToInt32(DaysTb.Text)));

                if (response.IsSuccess)
                {

                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
