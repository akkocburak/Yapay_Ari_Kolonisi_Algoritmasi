namespace ABC
{

    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nudKoloni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAlt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudUst = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCevrim = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDeneme = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).BeginInit();
            this.SuspendLayout();
            // 
            // nudKoloni
            // 
            this.nudKoloni.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudKoloni.Location = new System.Drawing.Point(166, 28);
            this.nudKoloni.Margin = new System.Windows.Forms.Padding(5);
            this.nudKoloni.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKoloni.Name = "nudKoloni";
            this.nudKoloni.Size = new System.Drawing.Size(205, 32);
            this.nudKoloni.TabIndex = 0;
            this.nudKoloni.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koloni Boyutu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(67, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alt Sınır";
            // 
            // nudAlt
            // 
            this.nudAlt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudAlt.Location = new System.Drawing.Point(166, 67);
            this.nudAlt.Margin = new System.Windows.Forms.Padding(5);
            this.nudAlt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAlt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudAlt.Name = "nudAlt";
            this.nudAlt.Size = new System.Drawing.Size(205, 32);
            this.nudAlt.TabIndex = 6;
            this.nudAlt.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(66, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Üst Sınır";
            // 
            // nudUst
            // 
            this.nudUst.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudUst.Location = new System.Drawing.Point(166, 103);
            this.nudUst.Margin = new System.Windows.Forms.Padding(5);
            this.nudUst.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUst.Name = "nudUst";
            this.nudUst.Size = new System.Drawing.Size(205, 32);
            this.nudUst.TabIndex = 8;
            this.nudUst.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHesapla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHesapla.Location = new System.Drawing.Point(208, 209);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(101, 40);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(28, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Çevrim Sayısı";
            // 
            // nudCevrim
            // 
            this.nudCevrim.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudCevrim.Location = new System.Drawing.Point(166, 159);
            this.nudCevrim.Margin = new System.Windows.Forms.Padding(5);
            this.nudCevrim.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCevrim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCevrim.Name = "nudCevrim";
            this.nudCevrim.Size = new System.Drawing.Size(205, 32);
            this.nudCevrim.TabIndex = 11;
            this.nudCevrim.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deneme Sayısı";
            // 
            // nudDeneme
            // 
            this.nudDeneme.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudDeneme.Location = new System.Drawing.Point(166, 131);
            this.nudDeneme.Margin = new System.Windows.Forms.Padding(5);
            this.nudDeneme.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDeneme.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeneme.Name = "nudDeneme";
            this.nudDeneme.Size = new System.Drawing.Size(205, 32);
            this.nudDeneme.TabIndex = 13;
            this.nudDeneme.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(623, 208);
            this.textBox1.TabIndex = 16;
            // 
            // chartFx
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFx.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFx.Legends.Add(legend1);
            this.chartFx.Location = new System.Drawing.Point(31, 281);
            this.chartFx.Name = "chartFx";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "fx";
            this.chartFx.Series.Add(series1);
            this.chartFx.Size = new System.Drawing.Size(983, 265);
            this.chartFx.TabIndex = 17;
            this.chartFx.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "X1 - X2 - Fx - Fit Değerleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1093, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartFx);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDeneme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCevrim);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudUst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudKoloni);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "ABC Ödevi Burak Akkoç";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudKoloni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudUst;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCevrim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDeneme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private System.Windows.Forms.Label label3;
    }
}

