using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using Weather.Api.Models;
using Weather.Infrastructure;

namespace Weather.ClientReceiver
{
    public partial class FmClientReceiver : Form
    {
        IHubProxy _hub;
        readonly Repository _repository;
        public FmClientReceiver()
        {
            InitializeComponent();
            _repository = new Repository();
            Receive();

        }

        private void Receive()
        {
            var connection = new HubConnection(ClientReceiverSettings.Default.Url);
            _hub = connection.CreateHubProxy("Weather");
            connection.Start().Wait();

            _hub.On("Receive", async x =>
            {
                WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(x);

                LblDate.Invoke((MethodInvoker)delegate
                {
                    LblDate.Text = Convert.ToString(DateTime.Now);
                });

                LblTemperature.Invoke((MethodInvoker)delegate
                {
                    LblTemperature.Text = $"{Convert.ToString(weather.Main.Temp)}ºC";
                });

                LblFeelsMainDescription.Invoke((MethodInvoker)delegate
                {
                    LblFeelsMainDescription.Text = $"Feels like {Convert.ToString(weather.Main.Feels_Like)}. {weather.Weather[0].Main}. {weather.Weather[0].Description}.";
                });

                LblWeather.Invoke((MethodInvoker)delegate
                {
                    LblWeather.Text = $"Temperature: \nMinimun: {Convert.ToString(weather.Main.Temp_Min)}ºC Maximun: {Convert.ToString(weather.Main.Temp_Max)}ºC \nHumidity: {Convert.ToString(weather.Main.Humidity)}%.";
                });

                await _repository.AddWeather(weather);
            });
        }
    }
}
