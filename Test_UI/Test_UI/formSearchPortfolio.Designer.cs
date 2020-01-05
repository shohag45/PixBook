namespace Test_UI
{
    partial class formSearchPortfolio
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelPortfolio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserNameDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperienceDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenresDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeesDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 406);
            this.panel1.TabIndex = 3;
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
            this.btnSignOut.Location = new System.Drawing.Point(0, 274);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(200, 44);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
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
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnBack.Location = new System.Drawing.Point(0, 318);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 44);
            this.btnBack.TabIndex = 2;
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
            this.btnExit.Location = new System.Drawing.Point(0, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.labelLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 75);
            this.panel3.TabIndex = 4;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(60, 25);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 30);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "PixBook";
            // 
            // labelPortfolio
            // 
            this.labelPortfolio.AutoSize = true;
            this.labelPortfolio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortfolio.ForeColor = System.Drawing.Color.White;
            this.labelPortfolio.Location = new System.Drawing.Point(209, 86);
            this.labelPortfolio.Name = "labelPortfolio";
            this.labelPortfolio.Size = new System.Drawing.Size(107, 23);
            this.labelPortfolio.TabIndex = 5;
            this.labelPortfolio.Text = "Portfolios : ";
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
            this.PhoneDB,
            this.ExperienceDB,
            this.GenresDB,
            this.FeesDB});
            this.dataGridView1.Location = new System.Drawing.Point(202, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 314);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // ExperienceDB
            // 
            this.ExperienceDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExperienceDB.DataPropertyName = "ExperienceDB";
            this.ExperienceDB.HeaderText = "Experience";
            this.ExperienceDB.Name = "ExperienceDB";
            // 
            // GenresDB
            // 
            this.GenresDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GenresDB.DataPropertyName = "GenresDB";
            this.GenresDB.HeaderText = "Genres";
            this.GenresDB.Name = "GenresDB";
            // 
            // FeesDB
            // 
            this.FeesDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeesDB.DataPropertyName = "FeesDB";
            this.FeesDB.HeaderText = "Fees";
            this.FeesDB.Name = "FeesDB";
            // 
            // formSearchPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPortfolio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSearchPortfolio";
            this.Text = "Portfolios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSearchPortfolio_FormClosing);
            this.Load += new System.EventHandler(this.formSearchPortfolio_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelPortfolio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperienceDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenresDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeesDB;
    }
}