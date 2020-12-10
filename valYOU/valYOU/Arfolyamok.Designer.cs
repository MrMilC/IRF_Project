﻿
namespace valYOU
{
    partial class Arfolyamok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arfolyamok));
            this.dgwRates = new System.Windows.Forms.DataGridView();
            this.chartRates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.labelRightArrow = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIntoWord = new valYOU.Entities.RoundButton();
            this.btnIntoPDF = new valYOU.Entities.RoundButton();
            this.btnIntoPNG = new valYOU.Entities.RoundButton();
            this.btnIntoExcel = new valYOU.Entities.RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRates
            // 
            this.dgwRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRates.Location = new System.Drawing.Point(12, 50);
            this.dgwRates.Name = "dgwRates";
            this.dgwRates.RowHeadersWidth = 51;
            this.dgwRates.Size = new System.Drawing.Size(480, 450);
            this.dgwRates.TabIndex = 0;
            // 
            // chartRates
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRates.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRates.Legends.Add(legend1);
            this.chartRates.Location = new System.Drawing.Point(492, 50);
            this.chartRates.Name = "chartRates";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRates.Series.Add(series1);
            this.chartRates.Size = new System.Drawing.Size(480, 450);
            this.chartRates.TabIndex = 1;
            this.chartRates.Text = "chart1";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpFrom.Location = new System.Drawing.Point(10, 13);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpTo.Location = new System.Drawing.Point(292, 13);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // cbCurrency
            // 
            this.cbCurrency.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(688, 13);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(60, 23);
            this.cbCurrency.TabIndex = 6;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            // 
            // labelRightArrow
            // 
            this.labelRightArrow.AutoSize = true;
            this.labelRightArrow.BackColor = System.Drawing.Color.Transparent;
            this.labelRightArrow.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightArrow.ForeColor = System.Drawing.Color.Orange;
            this.labelRightArrow.Location = new System.Drawing.Point(234, 11);
            this.labelRightArrow.Name = "labelRightArrow";
            this.labelRightArrow.Size = new System.Drawing.Size(56, 27);
            this.labelRightArrow.TabIndex = 20;
            this.labelRightArrow.Text = "Right";
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoSize = true;
            this.labelMax.BackColor = System.Drawing.Color.Transparent;
            this.labelMax.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMax.ForeColor = System.Drawing.Color.Red;
            this.labelMax.Location = new System.Drawing.Point(149, 587);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(46, 23);
            this.labelMax.TabIndex = 26;
            this.labelMax.Text = "Max";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Maximális érték:";
            // 
            // btnIntoWord
            // 
            this.btnIntoWord.BackColor = System.Drawing.Color.Transparent;
            this.btnIntoWord.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnIntoWord.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnIntoWord.FlatAppearance.BorderSize = 0;
            this.btnIntoWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntoWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntoWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntoWord.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIntoWord.Location = new System.Drawing.Point(783, 513);
            this.btnIntoWord.Name = "btnIntoWord";
            this.btnIntoWord.OnHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.btnIntoWord.OnHoverButtonColor = System.Drawing.Color.SteelBlue;
            this.btnIntoWord.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoWord.Size = new System.Drawing.Size(75, 75);
            this.btnIntoWord.TabIndex = 25;
            this.btnIntoWord.Text = "Word";
            this.btnIntoWord.TextColor = System.Drawing.Color.White;
            this.btnIntoWord.UseVisualStyleBackColor = false;
            // 
            // btnIntoPDF
            // 
            this.btnIntoPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnIntoPDF.BorderColor = System.Drawing.Color.Firebrick;
            this.btnIntoPDF.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnIntoPDF.FlatAppearance.BorderSize = 0;
            this.btnIntoPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntoPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntoPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntoPDF.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntoPDF.Location = new System.Drawing.Point(688, 513);
            this.btnIntoPDF.Name = "btnIntoPDF";
            this.btnIntoPDF.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.btnIntoPDF.OnHoverButtonColor = System.Drawing.Color.Firebrick;
            this.btnIntoPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoPDF.Size = new System.Drawing.Size(75, 75);
            this.btnIntoPDF.TabIndex = 24;
            this.btnIntoPDF.Text = "PDF";
            this.btnIntoPDF.TextColor = System.Drawing.Color.White;
            this.btnIntoPDF.UseVisualStyleBackColor = false;
            // 
            // btnIntoPNG
            // 
            this.btnIntoPNG.BackColor = System.Drawing.Color.Transparent;
            this.btnIntoPNG.BorderColor = System.Drawing.Color.Orange;
            this.btnIntoPNG.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnIntoPNG.FlatAppearance.BorderSize = 0;
            this.btnIntoPNG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntoPNG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntoPNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntoPNG.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntoPNG.Location = new System.Drawing.Point(591, 513);
            this.btnIntoPNG.Name = "btnIntoPNG";
            this.btnIntoPNG.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnIntoPNG.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnIntoPNG.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoPNG.Size = new System.Drawing.Size(75, 75);
            this.btnIntoPNG.TabIndex = 22;
            this.btnIntoPNG.Text = "PNG";
            this.btnIntoPNG.TextColor = System.Drawing.Color.White;
            this.btnIntoPNG.UseVisualStyleBackColor = false;
            this.btnIntoPNG.Click += new System.EventHandler(this.btnIntoPNG_Click);
            // 
            // btnIntoExcel
            // 
            this.btnIntoExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnIntoExcel.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnIntoExcel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnIntoExcel.FlatAppearance.BorderSize = 0;
            this.btnIntoExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntoExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntoExcel.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIntoExcel.Location = new System.Drawing.Point(292, 521);
            this.btnIntoExcel.Name = "btnIntoExcel";
            this.btnIntoExcel.OnHoverBorderColor = System.Drawing.Color.LimeGreen;
            this.btnIntoExcel.OnHoverButtonColor = System.Drawing.Color.LimeGreen;
            this.btnIntoExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoExcel.Size = new System.Drawing.Size(75, 75);
            this.btnIntoExcel.TabIndex = 4;
            this.btnIntoExcel.Text = "Excel";
            this.btnIntoExcel.TextColor = System.Drawing.Color.White;
            this.btnIntoExcel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Minimális érték:";
            // 
            // labelMin
            // 
            this.labelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMin.ForeColor = System.Drawing.Color.Lime;
            this.labelMin.Location = new System.Drawing.Point(149, 513);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(38, 23);
            this.labelMin.TabIndex = 29;
            this.labelMin.Text = "Min";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Átlagos érték:";
            // 
            // labelAvg
            // 
            this.labelAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvg.AutoSize = true;
            this.labelAvg.BackColor = System.Drawing.Color.Transparent;
            this.labelAvg.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvg.ForeColor = System.Drawing.Color.Aqua;
            this.labelAvg.Location = new System.Drawing.Point(149, 550);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(42, 23);
            this.labelAvg.TabIndex = 31;
            this.labelAvg.Text = "Avg";
            // 
            // Arfolyamok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.btnIntoWord);
            this.Controls.Add(this.btnIntoPDF);
            this.Controls.Add(this.btnIntoPNG);
            this.Controls.Add(this.labelRightArrow);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.btnIntoExcel);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.chartRates);
            this.Controls.Add(this.dgwRates);
            this.Name = "Arfolyamok";
            this.Text = "Arfolyamok";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRates;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private Entities.RoundButton btnIntoExcel;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label labelRightArrow;
        private Entities.RoundButton btnIntoPNG;
        private Entities.RoundButton btnIntoPDF;
        private Entities.RoundButton btnIntoWord;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAvg;
    }
}