namespace Test_UI
{
    partial class formLogin1
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
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.rtbUserName = new System.Windows.Forms.RichTextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panelLeftSide.Controls.Add(this.labelWelcome);
            this.panelLeftSide.Controls.Add(this.btnExit);
            this.panelLeftSide.Controls.Add(this.panelHeader);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(226, 481);
            this.panelLeftSide.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelWelcome.Location = new System.Drawing.Point(3, 92);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(224, 25);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "Welcome to PixBook!";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(0, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panelHeader.Controls.Add(this.labelLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(226, 56);
            this.panelHeader.TabIndex = 0;
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
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.Black;
            this.panelSignIn.Controls.Add(this.mtbPass);
            this.panelSignIn.Controls.Add(this.btnForgotPass);
            this.panelSignIn.Controls.Add(this.btnSignUp);
            this.panelSignIn.Controls.Add(this.btnSignIn);
            this.panelSignIn.Controls.Add(this.rtbUserName);
            this.panelSignIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSignIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSignIn.Location = new System.Drawing.Point(226, 56);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(666, 425);
            this.panelSignIn.TabIndex = 3;
            this.panelSignIn.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSignIn_Paint);
            // 
            // mtbPass
            // 
            this.mtbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbPass.Location = new System.Drawing.Point(242, 163);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.Size = new System.Drawing.Size(249, 27);
            this.mtbPass.TabIndex = 2;
            this.mtbPass.Text = "Password";
            this.mtbPass.Enter += new System.EventHandler(this.MtbPass_Enter);
            this.mtbPass.Leave += new System.EventHandler(this.MtbPass_Leave);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.ForeColor = System.Drawing.Color.White;
            this.btnForgotPass.Location = new System.Drawing.Point(242, 254);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(250, 37);
            this.btnForgotPass.TabIndex = 5;
            this.btnForgotPass.Text = "Forgot Password?";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.BtnForgotPass_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Green;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(242, 206);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(127, 37);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(373, 206);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(119, 37);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // rtbUserName
            // 
            this.rtbUserName.BackColor = System.Drawing.Color.White;
            this.rtbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtbUserName.Location = new System.Drawing.Point(242, 112);
            this.rtbUserName.MaxLength = 30;
            this.rtbUserName.Name = "rtbUserName";
            this.rtbUserName.Size = new System.Drawing.Size(250, 40);
            this.rtbUserName.TabIndex = 1;
            this.rtbUserName.Text = "User Name";
            this.rtbUserName.TextChanged += new System.EventHandler(this.RtbUserName_TextChanged);
            this.rtbUserName.Enter += new System.EventHandler(this.RtbUserName_Enter);
            this.rtbUserName.Leave += new System.EventHandler(this.RtbUserName_Leave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(226, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(658, 56);
            this.panelTop.TabIndex = 1;
            // 
            // formLogin1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeftSide);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogin1";
            this.Text = "Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLogin1_FormClosing);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.RichTextBox rtbUserName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.Label labelWelcome;
    }
}

