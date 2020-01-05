namespace Test_UI
{
    partial class formManageUsers1
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
            this.btnHome = new System.Windows.Forms.Button();
            this.mtbConfirmPass = new System.Windows.Forms.MaskedTextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowseUserPic = new System.Windows.Forms.Button();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
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
            this.labelPass = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.labelDetails = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserNameDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.mtbConfirmPass);
            this.panel1.Controls.Add(this.labelConfirmPass);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.mtbPass);
            this.panel1.Controls.Add(this.btnBrowseUserPic);
            this.panel1.Controls.Add(this.rtbAddress);
            this.panel1.Controls.Add(this.comboGender);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.tbPic);
            this.panel1.Controls.Add(this.tbPhn);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.tbFullName);
            this.panel1.Controls.Add(this.labelMail);
            this.panel1.Controls.Add(this.labelPic);
            this.panel1.Controls.Add(this.labelPhn);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.labelPass);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.labelFullName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 692);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 77);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(311, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // mtbConfirmPass
            // 
            this.mtbConfirmPass.Location = new System.Drawing.Point(116, 234);
            this.mtbConfirmPass.Name = "mtbConfirmPass";
            this.mtbConfirmPass.PasswordChar = '*';
            this.mtbConfirmPass.Size = new System.Drawing.Size(183, 26);
            this.mtbConfirmPass.TabIndex = 5;
            this.mtbConfirmPass.Leave += new System.EventHandler(this.MtbConfirmPass_Leave);
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPass.Location = new System.Drawing.Point(-2, 234);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(121, 17);
            this.labelConfirmPass.TabIndex = 29;
            this.labelConfirmPass.Text = "Confirm Password : ";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(116, 169);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(183, 26);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            this.tbUserName.MouseLeave += new System.EventHandler(this.TbUserName_MouseLeave);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(4, 171);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(106, 21);
            this.labelUserName.TabIndex = 27;
            this.labelUserName.Text = "User Name : ";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 560);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(311, 44);
            this.btnSignOut.TabIndex = 19;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
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
            this.btnBack.Location = new System.Drawing.Point(0, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(311, 44);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 648);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(311, 44);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // mtbPass
            // 
            this.mtbPass.Location = new System.Drawing.Point(116, 201);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.Size = new System.Drawing.Size(183, 26);
            this.mtbPass.TabIndex = 4;
            this.mtbPass.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbPass_MaskInputRejected);
            this.mtbPass.Leave += new System.EventHandler(this.MtbPass_Leave);
            // 
            // btnBrowseUserPic
            // 
            this.btnBrowseUserPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnBrowseUserPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseUserPic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseUserPic.ForeColor = System.Drawing.Color.White;
            this.btnBrowseUserPic.Location = new System.Drawing.Point(249, 484);
            this.btnBrowseUserPic.Name = "btnBrowseUserPic";
            this.btnBrowseUserPic.Size = new System.Drawing.Size(53, 27);
            this.btnBrowseUserPic.TabIndex = 11;
            this.btnBrowseUserPic.Text = "Browse";
            this.btnBrowseUserPic.UseVisualStyleBackColor = false;
            this.btnBrowseUserPic.Click += new System.EventHandler(this.btnBrowseUserPic_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(116, 330);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(183, 78);
            this.rtbAddress.TabIndex = 8;
            this.rtbAddress.Text = "";
            this.rtbAddress.Leave += new System.EventHandler(this.RtbAddress_Leave);
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(116, 296);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(183, 28);
            this.comboGender.TabIndex = 7;
            this.comboGender.Leave += new System.EventHandler(this.comboGender_Leave);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(116, 266);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(183, 26);
            this.tbAge.TabIndex = 6;
            this.tbAge.Leave += new System.EventHandler(this.TbAge_Leave);
            // 
            // tbPic
            // 
            this.tbPic.Location = new System.Drawing.Point(116, 484);
            this.tbPic.Name = "tbPic";
            this.tbPic.Size = new System.Drawing.Size(127, 26);
            this.tbPic.TabIndex = 17;
            // 
            // tbPhn
            // 
            this.tbPhn.Location = new System.Drawing.Point(116, 451);
            this.tbPhn.Name = "tbPhn";
            this.tbPhn.Size = new System.Drawing.Size(183, 26);
            this.tbPhn.TabIndex = 10;
            this.tbPhn.Leave += new System.EventHandler(this.TbPhn_Leave);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(116, 418);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(183, 26);
            this.tbMail.TabIndex = 9;
            this.tbMail.Leave += new System.EventHandler(this.TbMail_Leave);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(116, 137);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(183, 26);
            this.tbFullName.TabIndex = 2;
            this.tbFullName.Leave += new System.EventHandler(this.TbFullName_Leave);
            this.tbFullName.MouseLeave += new System.EventHandler(this.TbFullName_MouseLeave);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.White;
            this.labelMail.Location = new System.Drawing.Point(4, 421);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(54, 21);
            this.labelMail.TabIndex = 13;
            this.labelMail.Text = "Mail : ";
            // 
            // labelPic
            // 
            this.labelPic.AutoSize = true;
            this.labelPic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic.ForeColor = System.Drawing.Color.White;
            this.labelPic.Location = new System.Drawing.Point(4, 482);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(76, 21);
            this.labelPic.TabIndex = 12;
            this.labelPic.Text = "Picture : ";
            // 
            // labelPhn
            // 
            this.labelPhn.AutoSize = true;
            this.labelPhn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhn.ForeColor = System.Drawing.Color.White;
            this.labelPhn.Location = new System.Drawing.Point(4, 452);
            this.labelPhn.Name = "labelPhn";
            this.labelPhn.Size = new System.Drawing.Size(71, 21);
            this.labelPhn.TabIndex = 11;
            this.labelPhn.Text = "Phone : ";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(4, 328);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(84, 21);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address : ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Location = new System.Drawing.Point(4, 299);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(82, 21);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender : ";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(4, 202);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(94, 21);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password : ";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.Color.White;
            this.labelAge.Location = new System.Drawing.Point(3, 269);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(56, 21);
            this.labelAge.TabIndex = 14;
            this.labelAge.Text = "Age : ";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(4, 139);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(98, 21);
            this.labelFullName.TabIndex = 7;
            this.labelFullName.Text = "Full Name : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.labelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 77);
            this.panel2.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(120, 23);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 30);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "PixBook";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(311, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 77);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnShowAll);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnInsert);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(311, 648);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(889, 44);
            this.panel4.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(740, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 44);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(596, 0);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(144, 44);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(431, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 44);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(293, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 44);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(144, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 44);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(144, 44);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDetails.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.White;
            this.labelDetails.Location = new System.Drawing.Point(317, 121);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(146, 25);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "User Details : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameDB,
            this.FullNameDB,
            this.AgeDB,
            this.AddressDB,
            this.MailDB,
            this.PhoneDB});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(317, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 389);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserNameDB
            // 
            this.UserNameDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserNameDB.DataPropertyName = "UserNameDB";
            this.UserNameDB.HeaderText = "User Name";
            this.UserNameDB.Name = "UserNameDB";
            // 
            // FullNameDB
            // 
            this.FullNameDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameDB.DataPropertyName = "FullNameDB";
            this.FullNameDB.HeaderText = "Full Name";
            this.FullNameDB.Name = "FullNameDB";
            // 
            // AgeDB
            // 
            this.AgeDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AgeDB.DataPropertyName = "AgeDB";
            this.AgeDB.HeaderText = "Age";
            this.AgeDB.Name = "AgeDB";
            // 
            // AddressDB
            // 
            this.AddressDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddressDB.DataPropertyName = "AddressDB";
            this.AddressDB.HeaderText = "Address";
            this.AddressDB.Name = "AddressDB";
            // 
            // MailDB
            // 
            this.MailDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MailDB.DataPropertyName = "MailDB";
            this.MailDB.HeaderText = "Mail";
            this.MailDB.Name = "MailDB";
            // 
            // PhoneDB
            // 
            this.PhoneDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneDB.DataPropertyName = "PhoneDB";
            this.PhoneDB.HeaderText = "Phone Number";
            this.PhoneDB.Name = "PhoneDB";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formManageUsers1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formManageUsers1";
            this.Text = "Manage Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formManageUsers1_FormClosing);
            this.Load += new System.EventHandler(this.FormManageUsers1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.Button btnBrowseUserPic;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbPic;
        private System.Windows.Forms.TextBox tbPhn;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPic;
        private System.Windows.Forms.Label labelPhn;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MaskedTextBox mtbConfirmPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}