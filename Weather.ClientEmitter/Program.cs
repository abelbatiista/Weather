using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.ClientEmitter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            var connection = new HubConnection(ClientEmitterSettings.Default.Url);
            IHubProxy _hub = connection.CreateHubProxy("Weather");
            connection.Start().Wait();
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Enviar al cliente: ");
                string emitting = Console.ReadLine();
                _hub.Invoke("Notify", emitting).Wait();
                Console.WriteLine("Presione 'Enter' para salir.");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter) loop = false;
            }
        }
    }
}
