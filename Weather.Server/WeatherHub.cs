using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;

namespace Weather.Server
{
    [HubName("Weather")]
    public class WeatherHub : Hub
    {
        public void Notify(string info)
        {
            Clients.All.SendInfo(info);
        }
    }
}
