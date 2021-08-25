using Microsoft.Owin.Hosting;
using System;

namespace Weather.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = ServerSettings.Default.Url;
            using (WebApp.Start(url))
            {
                Console.WriteLine($"Server running at: {url}");
                Console.ReadKey();
            }
        }
    }
}
