using Microsoft.AspNet.SignalR.Client;
using System;
using Weather.Api;

namespace Weather.ClientEmitter
{
    public class Emitter
    {
        readonly IHubProxy _hub;
        readonly HubConnection connection;
        readonly Controller api;
        
        public Emitter()
        {
            connection = new HubConnection(ClientEmitterSettings.Default.Url);
            _hub = connection.CreateHubProxy("Weather");
            connection.Start().Wait();
            api = new Controller();
        }
        public void Emit()
        {
            string entity = api.Call();
            _hub.Invoke("Emit", entity).Wait();
        }
    }
}
