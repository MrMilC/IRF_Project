
namespace valYOU
{
    partial class Belepes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Belepes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.labelEye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFastLogin = new valYOU.Entities.RoundButton();
            this.btnEnter = new valYOU.Entities.RoundButton();
            this.btnClear = new valYOU.Entities.RoundButton();
            this.btnZero = new valYOU.Entities.RoundButton();
            this.btnNine = new valYOU.Entities.RoundButton();
            this.btnEight = new valYOU.Entities.RoundButton();
            this.btnSeven = new valYOU.Entities.RoundButton();
            this.btnSix = new valYOU.Entities.RoundButton();
            this.btnFive = new valYOU.Entities.RoundButton();
            this.btnFour = new valYOU.Entities.RoundButton();
            this.btnThree = new valYOU.Entities.RoundButton();
            this.btnTwo = new valYOU.Entities.RoundButton();
            this.btnOne = new valYOU.Entities.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "val";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(486, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOU";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(453, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 63);
            this.label3.TabIndex = 2;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(726, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kérjük adja meg a teszteléshez szükséges 8 számjegyű PIN-kódot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(128, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 47);
            this.label5.TabIndex = 15;
            this.label5.Text = "PIN-kód";
            // 
            // tbPIN
            // 
            this.tbPIN.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPIN.Location = new System.Drawing.Point(121, 322);
            this.tbPIN.MaxLength = 100;
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(163, 37);
            this.tbPIN.TabIndex = 16;
            this.tbPIN.UseSystemPasswordChar = true;
            this.tbPIN.TextChanged += new System.EventHandler(this.tbPIN_TextChanged);
            this.tbPIN.Enter += new System.EventHandler(this.tbPIN_Enter);
            this.tbPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPIN_KeyPress);
            this.tbPIN.Validating += new System.ComponentModel.CancelEventHandler(this.tbPIN_Validating);
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.BackColor = System.Drawing.Color.Transparent;
            this.cbVisible.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVisible.ForeColor = System.Drawing.Color.White;
            this.cbVisible.Location = new System.Drawing.Point(290, 334);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(15, 14);
            this.cbVisible.TabIndex = 18;
            this.cbVisible.UseVisualStyleBackColor = false;
            this.cbVisible.CheckedChanged += new System.EventHandler(this.cbVisible_CheckedChanged);
            // 
            // labelEye
            // 
            this.labelEye.AutoSize = true;
            this.labelEye.BackColor = System.Drawing.Color.Transparent;
            this.labelEye.Font = new System.Drawing.Font("Segoe MDL2 Assets", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEye.ForeColor = System.Drawing.Color.White;
            this.labelEye.Location = new System.Drawing.Point(307, 320);
            this.labelEye.Name = "labelEye";
            this.labelEye.Size = new System.Drawing.Size(68, 40);
            this.labelEye.TabIndex = 19;
            this.labelEye.Text = "Eye";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "FastLogin";
            // 
            // btnFastLogin
            // 
            this.btnFastLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFastLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnFastLogin.BorderColor = System.Drawing.Color.Aqua;
            this.btnFastLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnFastLogin.FlatAppearance.BorderSize = 0;
            this.btnFastLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFastLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFastLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastLogin.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastLogin.Location = new System.Drawing.Point(148, 582);
            this.btnFastLogin.Name = "btnFastLogin";
            this.btnFastLogin.OnHoverBorderColor = System.Drawing.Color.Aqua;
            this.btnFastLogin.OnHoverButtonColor = System.Drawing.Color.Aqua;
            this.btnFastLogin.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnFastLogin.Size = new System.Drawing.Size(100, 75);
            this.btnFastLogin.TabIndex = 20;
            this.btnFastLogin.TextColor = System.Drawing.Color.White;
            this.btnFastLogin.UseVisualStyleBackColor = false;
            this.btnFastLogin.Click += new System.EventHandler(this.btnFastLogin_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnEnter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(121, 365);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.OnHoverBorderColor = System.Drawing.Color.SpringGreen;
            this.btnEnter.OnHoverButtonColor = System.Drawing.Color.SpringGreen;
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnEnter.Size = new System.Drawing.Size(163, 50);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.TextColor = System.Drawing.Color.White;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Orange;
            this.btnClear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(413, 582);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnClear.Size = new System.Drawing.Size(462, 75);
            this.btnClear.TabIndex = 14;
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZero
            // 
            this.btnZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.BorderColor = System.Drawing.Color.Orange;
            this.btnZero.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZero.Location = new System.Drawing.Point(569, 488);
            this.btnZero.Name = "btnZero";
            this.btnZero.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnZero.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnZero.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnZero.Size = new System.Drawing.Size(150, 75);
            this.btnZero.TabIndex = 13;
            this.btnZero.Text = "0";
            this.btnZero.TextColor = System.Drawing.Color.White;
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnNine
            // 
            this.btnNine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNine.BackColor = System.Drawing.Color.Transparent;
            this.btnNine.BorderColor = System.Drawing.Color.Orange;
            this.btnNine.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNine.Location = new System.Drawing.Point(725, 395);
            this.btnNine.Name = "btnNine";
            this.btnNine.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnNine.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnNine.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnNine.Size = new System.Drawing.Size(150, 75);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.TextColor = System.Drawing.Color.White;
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnEight
            // 
            this.btnEight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEight.BackColor = System.Drawing.Color.Transparent;
            this.btnEight.BorderColor = System.Drawing.Color.Orange;
            this.btnEight.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEight.Location = new System.Drawing.Point(569, 395);
            this.btnEight.Name = "btnEight";
            this.btnEight.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnEight.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnEight.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnEight.Size = new System.Drawing.Size(150, 75);
            this.btnEight.TabIndex = 11;
            this.btnEight.Text = "8";
            this.btnEight.TextColor = System.Drawing.Color.White;
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnSeven.BorderColor = System.Drawing.Color.Orange;
            this.btnSeven.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeven.Location = new System.Drawing.Point(413, 395);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnSeven.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnSeven.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnSeven.Size = new System.Drawing.Size(150, 75);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.TextColor = System.Drawing.Color.White;
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSix
            // 
            this.btnSix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSix.BackColor = System.Drawing.Color.Transparent;
            this.btnSix.BorderColor = System.Drawing.Color.Orange;
            this.btnSix.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSix.Location = new System.Drawing.Point(725, 303);
            this.btnSix.Name = "btnSix";
            this.btnSix.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnSix.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnSix.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnSix.Size = new System.Drawing.Size(150, 75);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.TextColor = System.Drawing.Color.White;
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFive
            // 
            this.btnFive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFive.BackColor = System.Drawing.Color.Transparent;
            this.btnFive.BorderColor = System.Drawing.Color.Orange;
            this.btnFive.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFive.Location = new System.Drawing.Point(569, 303);
            this.btnFive.Name = "btnFive";
            this.btnFive.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnFive.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnFive.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnFive.Size = new System.Drawing.Size(150, 75);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.TextColor = System.Drawing.Color.White;
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.BorderColor = System.Drawing.Color.Orange;
            this.btnFour.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFour.Location = new System.Drawing.Point(413, 303);
            this.btnFour.Name = "btnFour";
            this.btnFour.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnFour.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnFour.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnFour.Size = new System.Drawing.Size(150, 75);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.TextColor = System.Drawing.Color.White;
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnThree
            // 
            this.btnThree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.BorderColor = System.Drawing.Color.Orange;
            this.btnThree.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnThree.Location = new System.Drawing.Point(725, 212);
            this.btnThree.Name = "btnThree";
            this.btnThree.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnThree.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnThree.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnThree.Size = new System.Drawing.Size(150, 75);
            this.btnThree.TabIndex = 6;
            this.btnThree.Text = "3";
            this.btnThree.TextColor = System.Drawing.Color.White;
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.BorderColor = System.Drawing.Color.Orange;
            this.btnTwo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTwo.Location = new System.Drawing.Point(569, 212);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnTwo.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnTwo.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnTwo.Size = new System.Drawing.Size(150, 75);
            this.btnTwo.TabIndex = 5;
            this.btnTwo.Text = "2";
            this.btnTwo.TextColor = System.Drawing.Color.White;
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnOne
            // 
            this.btnOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.BorderColor = System.Drawing.Color.Orange;
            this.btnOne.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOne.Location = new System.Drawing.Point(413, 212);
            this.btnOne.Name = "btnOne";
            this.btnOne.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnOne.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnOne.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnOne.Size = new System.Drawing.Size(150, 75);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.TextColor = System.Drawing.Color.White;
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // Belepes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFastLogin);
            this.Controls.Add(this.labelEye);
            this.Controls.Add(this.cbVisible);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Belepes";
            this.Text = "Belepes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Belepes_FormClosing);
            this.Load += new System.EventHandler(this.Belepes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Entities.RoundButton btnOne;
        private System.Windows.Forms.Label label4;
        private Entities.RoundButton btnTwo;
        private Entities.RoundButton btnThree;
        private Entities.RoundButton btnSix;
        private Entities.RoundButton btnFive;
        private Entities.RoundButton btnFour;
        private Entities.RoundButton btnNine;
        private Entities.RoundButton btnEight;
        private Entities.RoundButton btnSeven;
        private Entities.RoundButton btnClear;
        private Entities.RoundButton btnZero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPIN;
        private Entities.RoundButton btnEnter;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.Label labelEye;
        private Entities.RoundButton btnFastLogin;
        private System.Windows.Forms.Label label6;
    }
}