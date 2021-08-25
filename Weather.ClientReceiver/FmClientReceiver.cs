using Microsoft.AspNet.SignalR.Client;
using System.Windows.Forms;

namespace Weather.ClientReceiver
{
    public partial class FmClientReceiver : Form
    {
        IHubProxy _hub;
        public FmClientReceiver()
        {
            InitializeComponent();
            Receive($"a");

        }

        private void Receive(string a)
        {
            var connection = new HubConnection(ClientReceiverSettings.Default.Url);
            _hub = connection.CreateHubProxy("Weather");
            connection.Start().Wait();

            _hub.On("Receive", x =>
            {
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = x;
                });
            });
        }
    }
}
