namespace WeatherApp.Presentation
{
    partial class WeatherFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CurrentBt = new Button();
            CityTb = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ImperialRb = new RadioButton();
            MetricRb = new RadioButton();
            ForecastBt = new Button();
            label2 = new Label();
            DaysTb = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            CountryCodeTb = new TextBox();
            ResultTb = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CurrentBt
            // 
            CurrentBt.Location = new Point(59, 100);
            CurrentBt.Name = "CurrentBt";
            CurrentBt.Size = new Size(72, 23);
            CurrentBt.TabIndex = 0;
            CurrentBt.Text = "Current";
            CurrentBt.UseVisualStyleBackColor = true;
            CurrentBt.Click += BtSearch_Click;
            // 
            // CityTb
            // 
            CityTb.Location = new Point(12, 27);
            CityTb.Name = "CityTb";
            CityTb.Size = new Size(100, 23);
            CityTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "City";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ImperialRb);
            groupBox1.Controls.Add(MetricRb);
            groupBox1.Location = new Point(165, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(96, 75);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Units System";
            // 
            // ImperialRb
            // 
            ImperialRb.AutoSize = true;
            ImperialRb.Location = new Point(6, 46);
            ImperialRb.Name = "ImperialRb";
            ImperialRb.Size = new Size(68, 19);
            ImperialRb.TabIndex = 1;
            ImperialRb.Text = "Imperial";
            ImperialRb.UseVisualStyleBackColor = true;
            // 
            // MetricRb
            // 
            MetricRb.AutoSize = true;
            MetricRb.Checked = true;
            MetricRb.Location = new Point(6, 21);
            MetricRb.Name = "MetricRb";
            MetricRb.Size = new Size(59, 19);
            MetricRb.TabIndex = 0;
            MetricRb.TabStop = true;
            MetricRb.Text = "Metric";
            MetricRb.UseVisualStyleBackColor = true;
            // 
            // ForecastBt
            // 
            ForecastBt.Location = new Point(140, 100);
            ForecastBt.Name = "ForecastBt";
            ForecastBt.Size = new Size(72, 23);
            ForecastBt.TabIndex = 5;
            ForecastBt.Text = "Forecast";
            ForecastBt.UseVisualStyleBackColor = true;
            ForecastBt.Click += ForecastBt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Days";
            // 
            // DaysTb
            // 
            DaysTb.Location = new Point(12, 71);
            DaysTb.MaxLength = 1;
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(100, 23);
            DaysTb.TabIndex = 7;
            DaysTb.KeyPress += textBox2_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(ResultTb);
            panel1.Location = new Point(12, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 316);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 9);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 9;
            label3.Text = "C.C.";
            // 
            // CountryCodeTb
            // 
            CountryCodeTb.Location = new Point(118, 27);
            CountryCodeTb.Name = "CountryCodeTb";
            CountryCodeTb.Size = new Size(38, 23);
            CountryCodeTb.TabIndex = 10;
            // 
            // ResultTb
            // 
            ResultTb.Enabled = false;
            ResultTb.Location = new Point(3, 3);
            ResultTb.Multiline = true;
            ResultTb.Name = "ResultTb";
            ResultTb.Size = new Size(243, 310);
            ResultTb.TabIndex = 2;
            // 
            // WeatherFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 459);
            Controls.Add(CountryCodeTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(DaysTb);
            Controls.Add(label2);
            Controls.Add(ForecastBt);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(CityTb);
            Controls.Add(CurrentBt);
            Name = "WeatherFrm";
            Text = "Weather";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CurrentBt;
        private TextBox CityTb;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton ImperialRb;
        private RadioButton MetricRb;
        private Button ForecastBt;
        private Label label2;
        private TextBox DaysTb;
        private Panel panel1;
        private Label label3;
        private TextBox CountryCodeTb;
        private TextBox ResultTb;
    }
}
