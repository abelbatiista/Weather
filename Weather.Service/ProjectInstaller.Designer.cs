
using System.ServiceProcess;

namespace Weather.Service
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weatherServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.weatherServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // weatherServiceProcessInstaller
            // 
            this.weatherServiceProcessInstaller.Account = ServiceAccount.LocalSystem;
            this.weatherServiceProcessInstaller.Password = null;
            this.weatherServiceProcessInstaller.Username = null;
            // 
            // weatherServiceInstaller
            // 
            this.weatherServiceInstaller.ServiceName = "WeatherService";
            this.weatherServiceInstaller.DisplayName = "Weather: Service";
            this.weatherServiceInstaller.Description = "Service to indicate the weather at Santo Domingo's City.";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.weatherServiceProcessInstaller,
            this.weatherServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller weatherServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller weatherServiceInstaller;
    }
}