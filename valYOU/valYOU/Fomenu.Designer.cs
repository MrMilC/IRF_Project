
namespace valYOU
{
    partial class Fomenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fomenu));
            this.btnDivider = new System.Windows.Forms.Button();
            this.labelDown2 = new System.Windows.Forms.Label();
            this.labelUp1 = new System.Windows.Forms.Label();
            this.btnRegistration = new valYOU.Entities.RoundButton();
            this.btnRates = new valYOU.Entities.RoundButton();
            this.labelUp2 = new System.Windows.Forms.Label();
            this.labelDown1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDivider
            // 
            this.btnDivider.BackColor = System.Drawing.Color.Orange;
            this.btnDivider.Enabled = false;
            this.btnDivider.FlatAppearance.BorderSize = 0;
            this.btnDivider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivider.ForeColor = System.Drawing.Color.Orange;
            this.btnDivider.Location = new System.Drawing.Point(393, 100);
            this.btnDivider.Name = "btnDivider";
            this.btnDivider.Size = new System.Drawing.Size(5, 250);
            this.btnDivider.TabIndex = 1;
            this.btnDivider.UseVisualStyleBackColor = false;
            // 
            // labelDown2
            // 
            this.labelDown2.AutoSize = true;
            this.labelDown2.BackColor = System.Drawing.Color.Transparent;
            this.labelDown2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDown2.ForeColor = System.Drawing.Color.Orange;
            this.labelDown2.Location = new System.Drawing.Point(486, 98);
            this.labelDown2.Name = "labelDown2";
            this.labelDown2.Size = new System.Drawing.Size(157, 67);
            this.labelDown2.TabIndex = 20;
            this.labelDown2.Text = "Down";
            this.labelDown2.Visible = false;
            // 
            // labelUp1
            // 
            this.labelUp1.AutoSize = true;
            this.labelUp1.BackColor = System.Drawing.Color.Transparent;
            this.labelUp1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUp1.ForeColor = System.Drawing.Color.Orange;
            this.labelUp1.Location = new System.Drawing.Point(212, 283);
            this.labelUp1.Name = "labelUp1";
            this.labelUp1.Size = new System.Drawing.Size(93, 67);
            this.labelUp1.TabIndex = 21;
            this.labelUp1.Text = "Up";
            this.labelUp1.Visible = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.BorderColor = System.Drawing.Color.Orange;
            this.btnRegistration.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistration.Location = new System.Drawing.Point(433, 170);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnRegistration.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnRegistration.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnRegistration.Size = new System.Drawing.Size(200, 100);
            this.btnRegistration.TabIndex = 4;
            this.btnRegistration.Text = "Regisztráció";
            this.btnRegistration.TextColor = System.Drawing.Color.White;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            this.btnRegistration.MouseEnter += new System.EventHandler(this.btnRegistration_MouseEnter);
            this.btnRegistration.MouseLeave += new System.EventHandler(this.btnRegistration_MouseLeave);
            // 
            // btnRates
            // 
            this.btnRates.BackColor = System.Drawing.Color.Transparent;
            this.btnRates.BorderColor = System.Drawing.Color.Orange;
            this.btnRates.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnRates.FlatAppearance.BorderSize = 0;
            this.btnRates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRates.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRates.Location = new System.Drawing.Point(154, 170);
            this.btnRates.Name = "btnRates";
            this.btnRates.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnRates.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnRates.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnRates.Size = new System.Drawing.Size(200, 100);
            this.btnRates.TabIndex = 0;
            this.btnRates.Text = "Árfolyam";
            this.btnRates.TextColor = System.Drawing.Color.White;
            this.btnRates.UseVisualStyleBackColor = false;
            this.btnRates.Click += new System.EventHandler(this.btnRates_Click);
            this.btnRates.MouseEnter += new System.EventHandler(this.btnRates_MouseEnter);
            this.btnRates.MouseLeave += new System.EventHandler(this.btnRates_MouseLeave);
            // 
            // labelUp2
            // 
            this.labelUp2.AutoSize = true;
            this.labelUp2.BackColor = System.Drawing.Color.Transparent;
            this.labelUp2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUp2.ForeColor = System.Drawing.Color.Orange;
            this.labelUp2.Location = new System.Drawing.Point(486, 283);
            this.labelUp2.Name = "labelUp2";
            this.labelUp2.Size = new System.Drawing.Size(93, 67);
            this.labelUp2.TabIndex = 22;
            this.labelUp2.Text = "Up";
            this.labelUp2.Visible = false;
            // 
            // labelDown1
            // 
            this.labelDown1.AutoSize = true;
            this.labelDown1.BackColor = System.Drawing.Color.Transparent;
            this.labelDown1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDown1.ForeColor = System.Drawing.Color.Orange;
            this.labelDown1.Location = new System.Drawing.Point(212, 99);
            this.labelDown1.Name = "labelDown1";
            this.labelDown1.Size = new System.Drawing.Size(157, 67);
            this.labelDown1.TabIndex = 23;
            this.labelDown1.Text = "Down";
            this.labelDown1.Visible = false;
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDown1);
            this.Controls.Add(this.labelUp2);
            this.Controls.Add(this.labelUp1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnDivider);
            this.Controls.Add(this.btnRates);
            this.Controls.Add(this.labelDown2);
            this.Name = "Fomenu";
            this.Text = "Fomenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.RoundButton btnRates;
        private System.Windows.Forms.Button btnDivider;
        private Entities.RoundButton btnRegistration;
        private System.Windows.Forms.Label labelDown2;
        private System.Windows.Forms.Label labelUp1;
        private System.Windows.Forms.Label labelUp2;
        private System.Windows.Forms.Label labelDown1;
    }
}