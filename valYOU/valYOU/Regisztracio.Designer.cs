
namespace valYOU
{
    partial class Regisztracio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regisztracio));
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.timerReg = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorProv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.cbTermsOfUse = new System.Windows.Forms.CheckBox();
            this.btnInfo = new valYOU.Entities.RoundButton();
            this.btnTest = new valYOU.Entities.RoundButton();
            this.tbPIN = new valYOU.Entities.RoundTextBox();
            this.btnClear = new valYOU.Entities.RoundButton();
            this.btnIntoCSV = new valYOU.Entities.RoundButton();
            this.btnIntoPDF = new valYOU.Entities.RoundButton();
            this.btnIntoExcel = new valYOU.Entities.RoundButton();
            this.tbPhone = new valYOU.Entities.RoundTextBox();
            this.btnDelete = new valYOU.Entities.RoundButton();
            this.btnRegister = new valYOU.Entities.RoundButton();
            this.tbPassword2 = new valYOU.Entities.RoundTextBox();
            this.tbPassword = new valYOU.Entities.RoundTextBox();
            this.tbEmail2 = new valYOU.Entities.RoundTextBox();
            this.tbEmail = new valYOU.Entities.RoundTextBox();
            this.tbName = new valYOU.Entities.RoundTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUsers
            // 
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(12, 12);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.Size = new System.Drawing.Size(599, 537);
            this.dgwUsers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(629, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "*Teljes név";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(629, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "*Email";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(841, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "*Email ismét";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Orange;
            this.labelTime.Location = new System.Drawing.Point(1039, 12);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(18, 20);
            this.labelTime.TabIndex = 36;
            this.labelTime.Text = "T";
            // 
            // labelCountdown
            // 
            this.labelCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.BackColor = System.Drawing.Color.Transparent;
            this.labelCountdown.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountdown.ForeColor = System.Drawing.Color.Orange;
            this.labelCountdown.Location = new System.Drawing.Point(1034, 34);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(38, 15);
            this.labelCountdown.TabIndex = 37;
            this.labelCountdown.Text = "02:00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(841, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "*Jelszó ismét";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(629, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "*Jelszó";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(629, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Nem";
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "-",
            "Férfi",
            "Nő"});
            this.cbGender.Location = new System.Drawing.Point(633, 257);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 28);
            this.cbGender.TabIndex = 46;
            this.cbGender.Enter += new System.EventHandler(this.tbName_Enter);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(842, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "*Telefonszám (+36)";
            // 
            // ErrorProv2
            // 
            this.ErrorProv2.ContainerControl = this;
            this.ErrorProv2.RightToLeft = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(841, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 57;
            this.label10.Text = "*PIN-kód";
            // 
            // labelError2
            // 
            this.labelError2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError2.AutoSize = true;
            this.labelError2.BackColor = System.Drawing.Color.Transparent;
            this.labelError2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError2.ForeColor = System.Drawing.Color.White;
            this.labelError2.Location = new System.Drawing.Point(1042, 519);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(30, 33);
            this.labelError2.TabIndex = 60;
            this.labelError2.Text = "A";
            // 
            // cbTermsOfUse
            // 
            this.cbTermsOfUse.AutoSize = true;
            this.cbTermsOfUse.BackColor = System.Drawing.Color.Transparent;
            this.cbTermsOfUse.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTermsOfUse.ForeColor = System.Drawing.Color.Orange;
            this.cbTermsOfUse.Location = new System.Drawing.Point(845, 306);
            this.cbTermsOfUse.Name = "cbTermsOfUse";
            this.cbTermsOfUse.Size = new System.Drawing.Size(179, 23);
            this.cbTermsOfUse.TabIndex = 61;
            this.cbTermsOfUse.Text = "*Felhasználási feltételek";
            this.cbTermsOfUse.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderColor = System.Drawing.Color.Orange;
            this.btnInfo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(992, 205);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnInfo.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInfo.Size = new System.Drawing.Size(65, 65);
            this.btnInfo.TabIndex = 62;
            this.btnInfo.TextColor = System.Drawing.Color.White;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BorderColor = System.Drawing.Color.Orange;
            this.btnTest.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTest.Location = new System.Drawing.Point(714, 401);
            this.btnTest.Name = "btnTest";
            this.btnTest.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnTest.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnTest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTest.Size = new System.Drawing.Size(65, 65);
            this.btnTest.TabIndex = 59;
            this.btnTest.Text = "Teszt user";
            this.btnTest.TextColor = System.Drawing.Color.White;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbPIN
            // 
            this.tbPIN.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPIN.Location = new System.Drawing.Point(845, 191);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(125, 29);
            this.tbPIN.TabIndex = 56;
            this.tbPIN.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbPIN.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            this.tbPIN.Validating += new System.ComponentModel.CancelEventHandler(this.tbPIN_Validating);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Orange;
            this.btnClear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(714, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(65, 65);
            this.btnClear.TabIndex = 55;
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIntoCSV
            // 
            this.btnIntoCSV.BackColor = System.Drawing.Color.Transparent;
            this.btnIntoCSV.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIntoCSV.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnIntoCSV.FlatAppearance.BorderSize = 0;
            this.btnIntoCSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntoCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntoCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntoCSV.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIntoCSV.Location = new System.Drawing.Point(633, 484);
            this.btnIntoCSV.Name = "btnIntoCSV";
            this.btnIntoCSV.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIntoCSV.OnHoverButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIntoCSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoCSV.Size = new System.Drawing.Size(65, 65);
            this.btnIntoCSV.TabIndex = 54;
            this.btnIntoCSV.Text = "CSV";
            this.btnIntoCSV.TextColor = System.Drawing.Color.White;
            this.btnIntoCSV.UseVisualStyleBackColor = false;
            this.btnIntoCSV.Click += new System.EventHandler(this.btnIntoCSV_Click);
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
            this.btnIntoPDF.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIntoPDF.Location = new System.Drawing.Point(794, 485);
            this.btnIntoPDF.Name = "btnIntoPDF";
            this.btnIntoPDF.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.btnIntoPDF.OnHoverButtonColor = System.Drawing.Color.Firebrick;
            this.btnIntoPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoPDF.Size = new System.Drawing.Size(65, 65);
            this.btnIntoPDF.TabIndex = 53;
            this.btnIntoPDF.Text = "PDF";
            this.btnIntoPDF.TextColor = System.Drawing.Color.White;
            this.btnIntoPDF.UseVisualStyleBackColor = false;
            this.btnIntoPDF.Click += new System.EventHandler(this.btnIntoPDF_Click);
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
            this.btnIntoExcel.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIntoExcel.Location = new System.Drawing.Point(714, 484);
            this.btnIntoExcel.Name = "btnIntoExcel";
            this.btnIntoExcel.OnHoverBorderColor = System.Drawing.Color.LimeGreen;
            this.btnIntoExcel.OnHoverButtonColor = System.Drawing.Color.LimeGreen;
            this.btnIntoExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntoExcel.Size = new System.Drawing.Size(65, 65);
            this.btnIntoExcel.TabIndex = 52;
            this.btnIntoExcel.Text = "Excel";
            this.btnIntoExcel.TextColor = System.Drawing.Color.White;
            this.btnIntoExcel.UseVisualStyleBackColor = false;
            this.btnIntoExcel.Click += new System.EventHandler(this.btnIntoExcel_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPhone.Location = new System.Drawing.Point(845, 257);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(125, 29);
            this.tbPhone.TabIndex = 50;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbPhone.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Orange;
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(633, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(65, 65);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderColor = System.Drawing.Color.Orange;
            this.btnRegister.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(633, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnRegister.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.Size = new System.Drawing.Size(65, 65);
            this.btnRegister.TabIndex = 47;
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbPassword2
            // 
            this.tbPassword2.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword2.Location = new System.Drawing.Point(845, 121);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.Size = new System.Drawing.Size(175, 29);
            this.tbPassword2.TabIndex = 43;
            this.tbPassword2.UseSystemPasswordChar = true;
            this.tbPassword2.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbPassword2.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbPassword2.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword2_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(633, 121);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(175, 29);
            this.tbPassword.TabIndex = 42;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbEmail2
            // 
            this.tbEmail2.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail2.Location = new System.Drawing.Point(845, 52);
            this.tbEmail2.Name = "tbEmail2";
            this.tbEmail2.Size = new System.Drawing.Size(175, 29);
            this.tbEmail2.TabIndex = 39;
            this.tbEmail2.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail2.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbEmail2.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail2_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(633, 52);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(175, 29);
            this.tbEmail.TabIndex = 38;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(633, 191);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 29);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // Regisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.cbTermsOfUse);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIntoCSV);
            this.Controls.Add(this.btnIntoPDF);
            this.Controls.Add(this.btnIntoExcel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEmail2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgwUsers);
            this.Name = "Regisztracio";
            this.Text = "Regisztracio";
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsers;
        private Entities.RoundTextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Timer timerReg;
        private Entities.RoundTextBox tbEmail;
        private Entities.RoundTextBox tbEmail2;
        private Entities.RoundTextBox tbPassword2;
        private Entities.RoundTextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGender;
        private Entities.RoundButton btnRegister;
        private Entities.RoundButton btnDelete;
        private System.Windows.Forms.Label label9;
        private Entities.RoundTextBox tbPhone;
        private Entities.RoundButton btnIntoCSV;
        private Entities.RoundButton btnIntoPDF;
        private Entities.RoundButton btnIntoExcel;
        private Entities.RoundButton btnClear;
        private System.Windows.Forms.ErrorProvider ErrorProv2;
        private System.Windows.Forms.Label label10;
        private Entities.RoundTextBox tbPIN;
        private Entities.RoundButton btnTest;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.CheckBox cbTermsOfUse;
        private Entities.RoundButton btnInfo;
    }
}