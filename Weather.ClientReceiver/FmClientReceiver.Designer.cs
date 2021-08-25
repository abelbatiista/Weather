
namespace Weather.ClientReceiver
{
    partial class FmClientReceiver
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCity = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTemperature = new System.Windows.Forms.Label();
            this.LblFeelsMainDescription = new System.Windows.Forms.Label();
            this.LblWeather = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(12, 45);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(250, 24);
            this.LblCity.TabIndex = 0;
            this.LblCity.Text = "Santo Domingo City, DR";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblDate.Location = new System.Drawing.Point(13, 21);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(61, 15);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "DateTime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LblTemperature
            // 
            this.LblTemperature.AutoSize = true;
            this.LblTemperature.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemperature.Location = new System.Drawing.Point(88, 84);
            this.LblTemperature.Name = "LblTemperature";
            this.LblTemperature.Size = new System.Drawing.Size(157, 33);
            this.LblTemperature.TabIndex = 3;
            this.LblTemperature.Text = "Temperature";
            // 
            // LblFeelsMainDescription
            // 
            this.LblFeelsMainDescription.AutoSize = true;
            this.LblFeelsMainDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFeelsMainDescription.Location = new System.Drawing.Point(12, 129);
            this.LblFeelsMainDescription.Name = "LblFeelsMainDescription";
            this.LblFeelsMainDescription.Size = new System.Drawing.Size(163, 18);
            this.LblFeelsMainDescription.TabIndex = 4;
            this.LblFeelsMainDescription.Text = "FeelsMainDescription";
            // 
            // LblWeather
            // 
            this.LblWeather.AutoSize = true;
            this.LblWeather.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeather.Location = new System.Drawing.Point(28, 160);
            this.LblWeather.Name = "LblWeather";
            this.LblWeather.Size = new System.Drawing.Size(57, 16);
            this.LblWeather.TabIndex = 5;
            this.LblWeather.Text = "Weather";
            // 
            // FmClientReceiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.LblWeather);
            this.Controls.Add(this.LblFeelsMainDescription);
            this.Controls.Add(this.LblTemperature);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblCity);
            this.Name = "FmClientReceiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Receiver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTemperature;
        private System.Windows.Forms.Label LblFeelsMainDescription;
        private System.Windows.Forms.Label LblWeather;
    }
}

