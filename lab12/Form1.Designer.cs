namespace lab12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelWeatherState;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelState1;
        private System.Windows.Forms.Label labelState2;
        private System.Windows.Forms.Label labelState3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelWeatherState = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelState1 = new System.Windows.Forms.Label();
            this.labelState2 = new System.Windows.Forms.Label();
            this.labelState3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.Location = new System.Drawing.Point(65, 71);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(547, 374);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather.TabIndex = 0;
            this.pictureBoxWeather.TabStop = false;
            // 
            // labelWeatherState
            // 
            this.labelWeatherState.AutoSize = true;
            this.labelWeatherState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWeatherState.Location = new System.Drawing.Point(258, 474);
            this.labelWeatherState.Name = "labelWeatherState";
            this.labelWeatherState.Size = new System.Drawing.Size(119, 25);
            this.labelWeatherState.TabIndex = 1;
            this.labelWeatherState.Text = "Weather: ---";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonStartStop.Location = new System.Drawing.Point(762, 454);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(201, 64);
            this.buttonStartStop.TabIndex = 2;
            this.buttonStartStop.Text = "Press Start!";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelState1
            // 
            this.labelState1.AutoSize = true;
            this.labelState1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelState1.Location = new System.Drawing.Point(55, 71);
            this.labelState1.Name = "labelState1";
            this.labelState1.Size = new System.Drawing.Size(161, 25);
            this.labelState1.TabIndex = 3;
            this.labelState1.Text = "State 1 (clear): ...";
            // 
            // labelState2
            // 
            this.labelState2.AutoSize = true;
            this.labelState2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelState2.Location = new System.Drawing.Point(55, 156);
            this.labelState2.Name = "labelState2";
            this.labelState2.Size = new System.Drawing.Size(176, 25);
            this.labelState2.TabIndex = 4;
            this.labelState2.Text = "State 2 (cloudy): ...";
            // 
            // labelState3
            // 
            this.labelState3.AutoSize = true;
            this.labelState3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelState3.Location = new System.Drawing.Point(55, 233);
            this.labelState3.Name = "labelState3";
            this.labelState3.Size = new System.Drawing.Size(193, 25);
            this.labelState3.TabIndex = 5;
            this.labelState3.Text = "State 3 (overcast): ...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelState3);
            this.panel1.Controls.Add(this.labelState2);
            this.panel1.Controls.Add(this.labelState1);
            this.panel1.Location = new System.Drawing.Point(702, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 353);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1075, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelWeatherState);
            this.Controls.Add(this.pictureBoxWeather);
            this.Name = "Form1";
            this.Text = "Weather Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
    }
}
