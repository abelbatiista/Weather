using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;

namespace Weather.Server
{
    [HubName("Weather")]
    public class WeatherHub : Hub
    {
        public void Emit(string info)
        {
            Clients.All.Receive(info);
        }
    }
}
