// MainForm.Designer.cs

namespace WeatherDataApplication
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.richTextBoxWeatherData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter City Name:";
            
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(98, 12);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 1;
            
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Location = new System.Drawing.Point(204, 10);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(75, 23);
            this.buttonGetWeather.TabIndex = 2;
            this.buttonGetWeather.Text = "Get Weather";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            
            // 
            // richTextBoxWeatherData
            // 
            this.richTextBoxWeatherData.Location = new System.Drawing.Point(15, 39);
            this.richTextBoxWeatherData.Name = "richTextBoxWeatherData";
            this.richTextBoxWeatherData.Size = new System.Drawing.Size(264, 212);
            this.richTextBoxWeatherData.TabIndex = 3;
            this.richTextBoxWeatherData.Text = "";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Controls.Add(this.richTextBoxWeatherData);
            this.Controls.Add(this.buttonGetWeather);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "Weather Data App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.RichTextBox richTextBoxWeatherData;
    }
}