namespace Test_UI
{
    partial class formAdminHome1
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
            this.btnManagePhotographer = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelCurrentInfo = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnManagePhotographer);
            this.panel1.Controls.Add(this.btnManageUser);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 481);
            this.panel1.TabIndex = 0;
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
            this.btnSignOut.Location = new System.Drawing.Point(0, 349);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(200, 44);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // btnManagePhotographer
            // 
            this.btnManagePhotographer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManagePhotographer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagePhotographer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePhotographer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManagePhotographer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePhotographer.ForeColor = System.Drawing.Color.White;
            this.btnManagePhotographer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnManagePhotographer.Location = new System.Drawing.Point(0, 119);
            this.btnManagePhotographer.Name = "btnManagePhotographer";
            this.btnManagePhotographer.Size = new System.Drawing.Size(200, 44);
            this.btnManagePhotographer.TabIndex = 2;
            this.btnManagePhotographer.Text = "Manage Photographer";
            this.btnManagePhotographer.UseVisualStyleBackColor = true;
            this.btnManagePhotographer.Click += new System.EventHandler(this.BtnManagePhotographer_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.White;
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnManageUser.Location = new System.Drawing.Point(0, 75);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(200, 44);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.BtnManageUser_Click);
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
            this.btnBack.Location = new System.Drawing.Point(0, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 44);
            this.btnBack.TabIndex = 5;
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
            this.btnExit.Location = new System.Drawing.Point(0, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.labelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 75);
            this.panel2.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(56, 22);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 30);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "PixBook";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 75);
            this.panel3.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.labelWelcome.Location = new System.Drawing.Point(328, 91);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(214, 28);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome Admin,";
            // 
            // labelCurrentInfo
            // 
            this.labelCurrentInfo.AutoSize = true;
            this.labelCurrentInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentInfo.ForeColor = System.Drawing.Color.Aqua;
            this.labelCurrentInfo.Location = new System.Drawing.Point(222, 163);
            this.labelCurrentInfo.Name = "labelCurrentInfo";
            this.labelCurrentInfo.Size = new System.Drawing.Size(200, 23);
            this.labelCurrentInfo.TabIndex = 3;
            this.labelCurrentInfo.Text = "Current System Info : ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelInfo.Location = new System.Drawing.Point(420, 196);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(137, 22);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "System Details";
            // 
            // formAdminHome1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelCurrentInfo);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAdminHome1";
            this.Text = "Admin Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAdminHome1_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminHome1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnManagePhotographer;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelCurrentInfo;
        private System.Windows.Forms.Label labelInfo;
    }
}