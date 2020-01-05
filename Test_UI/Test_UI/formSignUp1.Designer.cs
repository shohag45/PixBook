namespace Test_UI
{
    partial class formSignUp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.clbGenres = new System.Windows.Forms.CheckedListBox();
            this.mtbConfirmPass = new System.Windows.Forms.MaskedTextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowseUserPic = new System.Windows.Forms.Button();
            this.btnSignUpAsPhotographer = new System.Windows.Forms.Button();
            this.btnSignUpUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.tbExperience = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPic = new System.Windows.Forms.TextBox();
            this.tbPhn = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPic = new System.Windows.Forms.Label();
            this.labelPhn = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFees = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelPhotographerGenres = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.labelPhotographerFillUp = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 45);
            this.panel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panelHeader.Controls.Add(this.labelLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(884, 45);
            this.panelHeader.TabIndex = 1;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(45, 12);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 30);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "PixBook";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 436);
            this.panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 50);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(0, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 47);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pbProfilePic);
            this.panel3.Controls.Add(this.clbGenres);
            this.panel3.Controls.Add(this.mtbConfirmPass);
            this.panel3.Controls.Add(this.labelConfirmPass);
            this.panel3.Controls.Add(this.tbUserName);
            this.panel3.Controls.Add(this.labelUserName);
            this.panel3.Controls.Add(this.mtbPass);
            this.panel3.Controls.Add(this.btnBrowseUserPic);
            this.panel3.Controls.Add(this.btnSignUpAsPhotographer);
            this.panel3.Controls.Add(this.btnSignUpUser);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.rtbAddress);
            this.panel3.Controls.Add(this.comboGender);
            this.panel3.Controls.Add(this.tbFees);
            this.panel3.Controls.Add(this.tbExperience);
            this.panel3.Controls.Add(this.tbAge);
            this.panel3.Controls.Add(this.tbPic);
            this.panel3.Controls.Add(this.tbPhn);
            this.panel3.Controls.Add(this.tbMail);
            this.panel3.Controls.Add(this.tbFullName);
            this.panel3.Controls.Add(this.labelMail);
            this.panel3.Controls.Add(this.labelPic);
            this.panel3.Controls.Add(this.labelPhn);
            this.panel3.Controls.Add(this.labelAddress);
            this.panel3.Controls.Add(this.labelGender);
            this.panel3.Controls.Add(this.labelFees);
            this.panel3.Controls.Add(this.labelExperience);
            this.panel3.Controls.Add(this.labelPass);
            this.panel3.Controls.Add(this.labelPhotographerGenres);
            this.panel3.Controls.Add(this.labelAge);
            this.panel3.Controls.Add(this.labelUserFullName);
            this.panel3.Controls.Add(this.labelPhotographerFillUp);
            this.panel3.Controls.Add(this.labelSignUp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(188, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 436);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(516, 300);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(138, 114);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 13;
            this.pbProfilePic.TabStop = false;
            // 
            // clbGenres
            // 
            this.clbGenres.BackColor = System.Drawing.Color.Black;
            this.clbGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbGenres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGenres.ForeColor = System.Drawing.Color.White;
            this.clbGenres.FormattingEnabled = true;
            this.clbGenres.Items.AddRange(new object[] {
            "Wedding",
            "Fashion",
            "Street",
            "Wild Life"});
            this.clbGenres.Location = new System.Drawing.Point(501, 153);
            this.clbGenres.Name = "clbGenres";
            this.clbGenres.Size = new System.Drawing.Size(187, 72);
            this.clbGenres.TabIndex = 12;
            this.clbGenres.SelectedIndexChanged += new System.EventHandler(this.ClbGenres_SelectedIndexChanged);
            // 
            // mtbConfirmPass
            // 
            this.mtbConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.mtbConfirmPass.Location = new System.Drawing.Point(153, 146);
            this.mtbConfirmPass.Name = "mtbConfirmPass";
            this.mtbConfirmPass.PasswordChar = '*';
            this.mtbConfirmPass.Size = new System.Drawing.Size(183, 23);
            this.mtbConfirmPass.TabIndex = 4;
            this.mtbConfirmPass.Leave += new System.EventHandler(this.MtbConfirmPass_Leave);
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPass.Location = new System.Drawing.Point(-2, 148);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(152, 20);
            this.labelConfirmPass.TabIndex = 10;
            this.labelConfirmPass.Text = "Confirm Password : ";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.Black;
            this.tbUserName.Location = new System.Drawing.Point(153, 93);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(183, 23);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(41, 92);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(106, 21);
            this.labelUserName.TabIndex = 8;
            this.labelUserName.Text = "User Name : ";
            // 
            // mtbPass
            // 
            this.mtbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPass.ForeColor = System.Drawing.Color.Black;
            this.mtbPass.Location = new System.Drawing.Point(153, 120);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.Size = new System.Drawing.Size(183, 23);
            this.mtbPass.TabIndex = 3;
            this.mtbPass.Leave += new System.EventHandler(this.MtbPass_Leave);
            // 
            // btnBrowseUserPic
            // 
            this.btnBrowseUserPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnBrowseUserPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseUserPic.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseUserPic.ForeColor = System.Drawing.Color.White;
            this.btnBrowseUserPic.Location = new System.Drawing.Point(286, 360);
            this.btnBrowseUserPic.Name = "btnBrowseUserPic";
            this.btnBrowseUserPic.Size = new System.Drawing.Size(53, 27);
            this.btnBrowseUserPic.TabIndex = 10;
            this.btnBrowseUserPic.Text = "Browse";
            this.btnBrowseUserPic.UseVisualStyleBackColor = false;
            this.btnBrowseUserPic.Click += new System.EventHandler(this.btnBrowseUserPic_Click);
            // 
            // btnSignUpAsPhotographer
            // 
            this.btnSignUpAsPhotographer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnSignUpAsPhotographer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpAsPhotographer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpAsPhotographer.ForeColor = System.Drawing.Color.White;
            this.btnSignUpAsPhotographer.Location = new System.Drawing.Point(10, 393);
            this.btnSignUpAsPhotographer.Name = "btnSignUpAsPhotographer";
            this.btnSignUpAsPhotographer.Size = new System.Drawing.Size(163, 40);
            this.btnSignUpAsPhotographer.TabIndex = 15;
            this.btnSignUpAsPhotographer.Text = "Sign Up As Photographer";
            this.btnSignUpAsPhotographer.UseVisualStyleBackColor = false;
            this.btnSignUpAsPhotographer.Click += new System.EventHandler(this.BtnSignUpAsPhotographer_Click);
            // 
            // btnSignUpUser
            // 
            this.btnSignUpUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnSignUpUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpUser.ForeColor = System.Drawing.Color.White;
            this.btnSignUpUser.Location = new System.Drawing.Point(179, 392);
            this.btnSignUpUser.Name = "btnSignUpUser";
            this.btnSignUpUser.Size = new System.Drawing.Size(160, 41);
            this.btnSignUpUser.TabIndex = 14;
            this.btnSignUpUser.Text = "Sign Up As User";
            this.btnSignUpUser.UseVisualStyleBackColor = false;
            this.btnSignUpUser.Click += new System.EventHandler(this.BtnSignUpUser_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.panel4.Location = new System.Drawing.Point(366, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 397);
            this.panel4.TabIndex = 4;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAddress.ForeColor = System.Drawing.Color.Black;
            this.rtbAddress.Location = new System.Drawing.Point(153, 229);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(183, 61);
            this.rtbAddress.TabIndex = 7;
            this.rtbAddress.Text = "";
            this.rtbAddress.Leave += new System.EventHandler(this.RtbAddress_Leave);
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.ForeColor = System.Drawing.Color.Black;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(153, 201);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(183, 25);
            this.comboGender.TabIndex = 6;
            // 
            // tbFees
            // 
            this.tbFees.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFees.ForeColor = System.Drawing.Color.Black;
            this.tbFees.Location = new System.Drawing.Point(501, 247);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(187, 23);
            this.tbFees.TabIndex = 13;
            this.tbFees.Leave += new System.EventHandler(this.TbFees_Leave);
            // 
            // tbExperience
            // 
            this.tbExperience.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExperience.ForeColor = System.Drawing.Color.Black;
            this.tbExperience.Location = new System.Drawing.Point(501, 103);
            this.tbExperience.Name = "tbExperience";
            this.tbExperience.Size = new System.Drawing.Size(183, 23);
            this.tbExperience.TabIndex = 11;
            this.tbExperience.Leave += new System.EventHandler(this.TbExperience_Leave);
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.ForeColor = System.Drawing.Color.Black;
            this.tbAge.Location = new System.Drawing.Point(153, 174);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(183, 23);
            this.tbAge.TabIndex = 5;
            this.tbAge.Leave += new System.EventHandler(this.TbAge_Leave);
            // 
            // tbPic
            // 
            this.tbPic.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPic.ForeColor = System.Drawing.Color.Black;
            this.tbPic.Location = new System.Drawing.Point(153, 360);
            this.tbPic.Name = "tbPic";
            this.tbPic.Size = new System.Drawing.Size(127, 21);
            this.tbPic.TabIndex = 1;
            this.tbPic.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tbPhn
            // 
            this.tbPhn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhn.ForeColor = System.Drawing.Color.Black;
            this.tbPhn.Location = new System.Drawing.Point(153, 327);
            this.tbPhn.Name = "tbPhn";
            this.tbPhn.Size = new System.Drawing.Size(183, 23);
            this.tbPhn.TabIndex = 9;
            this.tbPhn.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.tbPhn.Leave += new System.EventHandler(this.TbPhn_Leave);
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.ForeColor = System.Drawing.Color.Black;
            this.tbMail.Location = new System.Drawing.Point(153, 296);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(183, 23);
            this.tbMail.TabIndex = 8;
            this.tbMail.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.tbMail.Leave += new System.EventHandler(this.TbMail_Leave);
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullName.ForeColor = System.Drawing.Color.Black;
            this.tbFullName.Location = new System.Drawing.Point(153, 67);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(183, 23);
            this.tbFullName.TabIndex = 1;
            this.tbFullName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.tbFullName.Leave += new System.EventHandler(this.TbFullName_Leave);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.White;
            this.labelMail.Location = new System.Drawing.Point(41, 297);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(54, 21);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "Mail : ";
            // 
            // labelPic
            // 
            this.labelPic.AutoSize = true;
            this.labelPic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic.ForeColor = System.Drawing.Color.White;
            this.labelPic.Location = new System.Drawing.Point(41, 358);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(76, 21);
            this.labelPic.TabIndex = 0;
            this.labelPic.Text = "Picture : ";
            this.labelPic.Click += new System.EventHandler(this.Label5_Click);
            // 
            // labelPhn
            // 
            this.labelPhn.AutoSize = true;
            this.labelPhn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhn.ForeColor = System.Drawing.Color.White;
            this.labelPhn.Location = new System.Drawing.Point(41, 328);
            this.labelPhn.Name = "labelPhn";
            this.labelPhn.Size = new System.Drawing.Size(71, 21);
            this.labelPhn.TabIndex = 0;
            this.labelPhn.Text = "Phone : ";
            this.labelPhn.Click += new System.EventHandler(this.Label5_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(41, 229);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(84, 21);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address : ";
            this.labelAddress.Click += new System.EventHandler(this.Label4_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Location = new System.Drawing.Point(44, 204);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(82, 21);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender : ";
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFees.ForeColor = System.Drawing.Color.White;
            this.labelFees.Location = new System.Drawing.Point(430, 247);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(56, 21);
            this.labelFees.TabIndex = 0;
            this.labelFees.Text = "Fees : ";
            this.labelFees.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExperience.ForeColor = System.Drawing.Color.White;
            this.labelExperience.Location = new System.Drawing.Point(393, 100);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(108, 21);
            this.labelExperience.TabIndex = 0;
            this.labelExperience.Text = "Experience : ";
            this.labelExperience.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(44, 120);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(94, 21);
            this.labelPass.TabIndex = 0;
            this.labelPass.Text = "Password : ";
            this.labelPass.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // labelPhotographerGenres
            // 
            this.labelPhotographerGenres.AutoSize = true;
            this.labelPhotographerGenres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotographerGenres.ForeColor = System.Drawing.Color.White;
            this.labelPhotographerGenres.Location = new System.Drawing.Point(409, 143);
            this.labelPhotographerGenres.Name = "labelPhotographerGenres";
            this.labelPhotographerGenres.Size = new System.Drawing.Size(77, 21);
            this.labelPhotographerGenres.TabIndex = 0;
            this.labelPhotographerGenres.Text = "Genres : ";
            this.labelPhotographerGenres.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.Color.White;
            this.labelAge.Location = new System.Drawing.Point(44, 176);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(56, 21);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Age : ";
            this.labelAge.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFullName.ForeColor = System.Drawing.Color.White;
            this.labelUserFullName.Location = new System.Drawing.Point(41, 67);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(98, 21);
            this.labelUserFullName.TabIndex = 0;
            this.labelUserFullName.Text = "Full Name : ";
            // 
            // labelPhotographerFillUp
            // 
            this.labelPhotographerFillUp.AutoSize = true;
            this.labelPhotographerFillUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotographerFillUp.ForeColor = System.Drawing.Color.White;
            this.labelPhotographerFillUp.Location = new System.Drawing.Point(393, 29);
            this.labelPhotographerFillUp.Name = "labelPhotographerFillUp";
            this.labelPhotographerFillUp.Size = new System.Drawing.Size(243, 19);
            this.labelPhotographerFillUp.TabIndex = 0;
            this.labelPhotographerFillUp.Text = "Only Fill Up For Photographer : ";
            this.labelPhotographerFillUp.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.White;
            this.labelSignUp.Location = new System.Drawing.Point(6, 29);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(83, 19);
            this.labelSignUp.TabIndex = 0;
            this.labelSignUp.Text = "Sign Up :  ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formSignUp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSignUp1";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSignUp1_FormClosing);
            this.Load += new System.EventHandler(this.FormSignUp1_Load);
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPhn;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label labelPic;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbPic;
        private System.Windows.Forms.TextBox tbPhn;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelPhotographerGenres;
        private System.Windows.Forms.Label labelPhotographerFillUp;
        private System.Windows.Forms.Button btnBrowseUserPic;
        private System.Windows.Forms.Button btnSignUpUser;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.TextBox tbExperience;
        private System.Windows.Forms.Button btnSignUpAsPhotographer;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MaskedTextBox mtbConfirmPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.CheckedListBox clbGenres;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbProfilePic;
    }
}