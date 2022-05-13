namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.NumericUpDown();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 167);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(580, 311);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(138, 116);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(144, 39);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Средняя интенсивность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество экспериментов";
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(188, 73);
            this.lambda.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(94, 20);
            this.lambda.TabIndex = 6;
            this.lambda.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cb1
            // 
            this.cb1.FormatString = "N0";
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cb1.Location = new System.Drawing.Point(188, 36);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(94, 21);
            this.cb1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Средняя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дисперсия";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(408, 36);
            this.tbM.Name = "tbM";
            this.tbM.ReadOnly = true;
            this.tbM.Size = new System.Drawing.Size(74, 20);
            this.tbM.TabIndex = 12;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(408, 75);
            this.tbD.Name = "tbD";
            this.tbD.ReadOnly = true;
            this.tbD.Size = new System.Drawing.Size(74, 20);
            this.tbD.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Хи-квадрат";
            // 
            // tbChi
            // 
            this.tbChi.Location = new System.Drawing.Point(434, 135);
            this.tbChi.Name = "tbChi";
            this.tbChi.ReadOnly = true;
            this.tbChi.Size = new System.Drawing.Size(48, 20);
            this.tbChi.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 488);
            this.Controls.Add(this.tbChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lambda;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbChi;
    }
}

