namespace Test_UI
{
    partial class formUserHome
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
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnShowPortfolio = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelNameGender = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnRequests);
            this.panel1.Controls.Add(this.btnShowPortfolio);
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
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequests.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRequests.Location = new System.Drawing.Point(0, 44);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(200, 44);
            this.btnRequests.TabIndex = 2;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnShowPortfolio
            // 
            this.btnShowPortfolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowPortfolio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPortfolio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowPortfolio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPortfolio.ForeColor = System.Drawing.Color.White;
            this.btnShowPortfolio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShowPortfolio.Location = new System.Drawing.Point(0, 0);
            this.btnShowPortfolio.Name = "btnShowPortfolio";
            this.btnShowPortfolio.Size = new System.Drawing.Size(200, 44);
            this.btnShowPortfolio.TabIndex = 1;
            this.btnShowPortfolio.Text = "Portfolios";
            this.btnShowPortfolio.UseVisualStyleBackColor = true;
            this.btnShowPortfolio.Click += new System.EventHandler(this.BtnShowPortfolio_Click);
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
            this.btnBack.TabIndex = 3;
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
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(612, 39);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(114, 25);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome,";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.labelLogo);
            this.panel3.Controls.Add(this.labelWelcome);
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
            this.labelLogo.Location = new System.Drawing.Point(54, 23);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 30);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "PixBook";
            // 
            // labelNameGender
            // 
            this.labelNameGender.AutoSize = true;
            this.labelNameGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameGender.ForeColor = System.Drawing.Color.White;
            this.labelNameGender.Location = new System.Drawing.Point(359, 119);
            this.labelNameGender.Name = "labelNameGender";
            this.labelNameGender.Size = new System.Drawing.Size(96, 21);
            this.labelNameGender.TabIndex = 5;
            this.labelNameGender.Text = "Name,Age";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(643, 89);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(110, 21);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "labelAddress";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(358, 86);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(117, 25);
            this.labelUserName.TabIndex = 8;
            this.labelUserName.Text = "UserName";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(206, 83);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(146, 97);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 9;
            this.pbProfilePic.TabStop = false;
            // 
            // labelDetails
            // 
            this.labelDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelDetails.Location = new System.Drawing.Point(299, 233);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(517, 190);
            this.labelDetails.TabIndex = 10;
            this.labelDetails.Text = "PixBook! ";
            // 
            // formUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.pbProfilePic);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNameGender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUserHome";
            this.Text = "User Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formUserHome_FormClosing);
            this.Load += new System.EventHandler(this.FormUserHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnShowPortfolio;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelNameGender;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Label labelDetails;
    }
}