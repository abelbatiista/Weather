using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
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

                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = weather.Weather[0].Description;
                });

                await _repository.AddWeather(weather);
            });
        }
    }
}
