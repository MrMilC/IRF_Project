
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelDown = new System.Windows.Forms.Label();
            this.btnRegistration = new valYOU.Entities.RoundButton();
            this.btnRates = new valYOU.Entities.RoundButton();
            this.labelUp = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(404, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 5);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(137, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 5);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.BackColor = System.Drawing.Color.Transparent;
            this.labelDown.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDown.ForeColor = System.Drawing.Color.Orange;
            this.labelDown.Location = new System.Drawing.Point(486, 98);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(157, 67);
            this.labelDown.TabIndex = 20;
            this.labelDown.Text = "Down";
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
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.BackColor = System.Drawing.Color.Transparent;
            this.labelUp.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUp.ForeColor = System.Drawing.Color.Orange;
            this.labelUp.Location = new System.Drawing.Point(212, 273);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(93, 67);
            this.labelUp.TabIndex = 21;
            this.labelUp.Text = "Up";
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUp);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDivider);
            this.Controls.Add(this.btnRates);
            this.Controls.Add(this.labelDown);
            this.Name = "Fomenu";
            this.Text = "Fomenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.RoundButton btnRates;
        private System.Windows.Forms.Button btnDivider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Entities.RoundButton btnRegistration;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Label labelUp;
    }
}