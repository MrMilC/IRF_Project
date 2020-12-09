
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
            this.label1 = new System.Windows.Forms.Label();
            this.PNG = new System.Windows.Forms.Label();
            this.btnIntoPNG = new valYOU.Entities.RoundButton();
            this.btnIntoExcel = new valYOU.Entities.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRates
            // 
            this.dgwRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRates.Location = new System.Drawing.Point(10, 50);
            this.dgwRates.Name = "dgwRates";
            this.dgwRates.RowHeadersWidth = 51;
            this.dgwRates.Size = new System.Drawing.Size(446, 321);
            this.dgwRates.TabIndex = 0;
            // 
            // chartRates
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRates.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRates.Legends.Add(legend1);
            this.chartRates.Location = new System.Drawing.Point(462, 50);
            this.chartRates.Name = "chartRates";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRates.Series.Add(series1);
            this.chartRates.Size = new System.Drawing.Size(398, 321);
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
            this.dtpTo.Location = new System.Drawing.Point(256, 13);
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
            this.cbCurrency.Location = new System.Drawing.Point(462, 13);
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
            this.labelRightArrow.Location = new System.Drawing.Point(214, 11);
            this.labelRightArrow.Name = "labelRightArrow";
            this.labelRightArrow.Size = new System.Drawing.Size(56, 27);
            this.labelRightArrow.TabIndex = 20;
            this.labelRightArrow.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(886, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Excel";
            // 
            // PNG
            // 
            this.PNG.AutoSize = true;
            this.PNG.BackColor = System.Drawing.Color.Transparent;
            this.PNG.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNG.ForeColor = System.Drawing.Color.Orange;
            this.PNG.Location = new System.Drawing.Point(886, 312);
            this.PNG.Name = "PNG";
            this.PNG.Size = new System.Drawing.Size(67, 31);
            this.PNG.TabIndex = 23;
            this.PNG.Text = "PNG";
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
            this.btnIntoPNG.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntoPNG.Location = new System.Drawing.Point(883, 233);
            this.btnIntoPNG.Name = "btnIntoPNG";
            this.btnIntoPNG.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnIntoPNG.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnIntoPNG.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnIntoPNG.Size = new System.Drawing.Size(75, 75);
            this.btnIntoPNG.TabIndex = 22;
            this.btnIntoPNG.TextColor = System.Drawing.Color.White;
            this.btnIntoPNG.UseVisualStyleBackColor = false;
            this.btnIntoPNG.Click += new System.EventHandler(this.btnIntoPNG_Click);
            // 
            // btnIntoExcel
            // 
            this.btnIntoExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnIntoExcel.BorderColor = System.Drawing.Color.Orange;
            this.btnIntoExcel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnIntoExcel.FlatAppearance.BorderSize = 0;
            this.btnIntoExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntoExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntoExcel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntoExcel.Location = new System.Drawing.Point(883, 83);
            this.btnIntoExcel.Name = "btnIntoExcel";
            this.btnIntoExcel.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnIntoExcel.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnIntoExcel.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnIntoExcel.Size = new System.Drawing.Size(75, 75);
            this.btnIntoExcel.TabIndex = 4;
            this.btnIntoExcel.TextColor = System.Drawing.Color.White;
            this.btnIntoExcel.UseVisualStyleBackColor = false;
            // 
            // Arfolyamok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.PNG);
            this.Controls.Add(this.btnIntoPNG);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PNG;
        private Entities.RoundButton btnIntoPNG;
    }
}