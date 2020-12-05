
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
            this.roundButton1 = new valYOU.Entities.RoundButton();
            this.btnDivider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundButton1.Location = new System.Drawing.Point(210, 184);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.roundButton1.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.roundButton1.Size = new System.Drawing.Size(161, 62);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // btnDivider
            // 
            this.btnDivider.BackColor = System.Drawing.Color.Orange;
            this.btnDivider.ForeColor = System.Drawing.Color.Orange;
            this.btnDivider.Location = new System.Drawing.Point(400, 75);
            this.btnDivider.Name = "btnDivider";
            this.btnDivider.Size = new System.Drawing.Size(16, 113);
            this.btnDivider.TabIndex = 1;
            this.btnDivider.UseVisualStyleBackColor = false;
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDivider);
            this.Controls.Add(this.roundButton1);
            this.Name = "Fomenu";
            this.Text = "Fomenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Entities.RoundButton roundButton1;
        private System.Windows.Forms.Button btnDivider;
    }
}