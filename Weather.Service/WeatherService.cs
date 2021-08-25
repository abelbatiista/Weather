using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Weather.ClientEmitter;

namespace Weather.Service
{
    public partial class WeatherService : ServiceBase
    {
        private readonly Timer timer;
        private readonly Emitter emitter;

        public WeatherService()
        {
            InitializeComponent();
            timer = new Timer();
            emitter = new Emitter();
        }

        protected override void OnStart(string[] args)
        {
            WrittingToFile($"The service was started at {DateTime.Now:dd/MM/yyyy hh:mm:ss}");
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = (1000 * 60/* * 60*/);
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WrittingToFile($"The service was stopped at {DateTime.Now:dd/MM/yyyy hh:mm:ss}");
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WrittingToFile($"The service was executed again at {DateTime.Now:dd/MM/yyyy hh:mm:ss}");
            emitter.Emit();
        }

        private void WrittingToFile(string message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";

            if (!File.Exists(filepath))
            {
                using (StreamWriter streamWriter = File.CreateText(filepath))
                {
                    streamWriter.WriteLine(message);
                }
            }
            else
            {
                using (StreamWriter streamWriter = File.AppendText(filepath))
                {
                    streamWriter.WriteLine(message);
                }
            }
        }

        public void RunAsConsole(string[] args)
        {
            OnStart(args);
            Console.WriteLine("Service Running as Console Application now.");
            Console.ReadKey();
            OnStop();
        }
    }
}
