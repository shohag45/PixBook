namespace Test_UI
{
    partial class formHiring
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
            this.PhotographerInfoPanel = new System.Windows.Forms.Panel();
            this.pbPhotographerInfoPic = new System.Windows.Forms.PictureBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelPhotographerInfo = new System.Windows.Forms.Label();
            this.labelHirePhotographer = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelHireTo = new System.Windows.Forms.Label();
            this.dtpHireFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpHireTo = new System.Windows.Forms.DateTimePicker();
            this.labelAddress = new System.Windows.Forms.Label();
            this.rtbPlace = new System.Windows.Forms.RichTextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PhotographerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotographerInfoPic)).BeginInit();
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
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(112)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.labelLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 75);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.labelLogo.Click += new System.EventHandler(this.labelLogo_Click);
            // 
            // PhotographerInfoPanel
            // 
            this.PhotographerInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.PhotographerInfoPanel.Controls.Add(this.pbPhotographerInfoPic);
            this.PhotographerInfoPanel.Controls.Add(this.labelDetails);
            this.PhotographerInfoPanel.Controls.Add(this.labelPhotographerInfo);
            this.PhotographerInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PhotographerInfoPanel.Location = new System.Drawing.Point(615, 75);
            this.PhotographerInfoPanel.Name = "PhotographerInfoPanel";
            this.PhotographerInfoPanel.Size = new System.Drawing.Size(269, 406);
            this.PhotographerInfoPanel.TabIndex = 21;
            this.PhotographerInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PhotographerInfoPanel_Paint);
            // 
            // pbPhotographerInfoPic
            // 
            this.pbPhotographerInfoPic.Location = new System.Drawing.Point(53, 43);
            this.pbPhotographerInfoPic.Name = "pbPhotographerInfoPic";
            this.pbPhotographerInfoPic.Size = new System.Drawing.Size(145, 94);
            this.pbPhotographerInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhotographerInfoPic.TabIndex = 2;
            this.pbPhotographerInfoPic.TabStop = false;
            this.pbPhotographerInfoPic.Click += new System.EventHandler(this.pbPhotographerInfoPic_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDetails.Location = new System.Drawing.Point(28, 164);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(159, 20);
            this.labelDetails.TabIndex = 1;
            this.labelDetails.Text = "PhotographerDetails";
            this.labelDetails.Click += new System.EventHandler(this.labelDetails_Click);
            // 
            // labelPhotographerInfo
            // 
            this.labelPhotographerInfo.AutoSize = true;
            this.labelPhotographerInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotographerInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhotographerInfo.Location = new System.Drawing.Point(13, 12);
            this.labelPhotographerInfo.Name = "labelPhotographerInfo";
            this.labelPhotographerInfo.Size = new System.Drawing.Size(155, 19);
            this.labelPhotographerInfo.TabIndex = 0;
            this.labelPhotographerInfo.Text = "Photographer Info :";
            this.labelPhotographerInfo.Click += new System.EventHandler(this.labelPhotographerInfo_Click);
            // 
            // labelHirePhotographer
            // 
            this.labelHirePhotographer.AutoSize = true;
            this.labelHirePhotographer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHirePhotographer.ForeColor = System.Drawing.Color.White;
            this.labelHirePhotographer.Location = new System.Drawing.Point(206, 99);
            this.labelHirePhotographer.Name = "labelHirePhotographer";
            this.labelHirePhotographer.Size = new System.Drawing.Size(155, 20);
            this.labelHirePhotographer.TabIndex = 22;
            this.labelHirePhotographer.Text = "Hire Photographer : ";
            this.labelHirePhotographer.Click += new System.EventHandler(this.labelHirePhotographer_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.ForeColor = System.Drawing.Color.White;
            this.labelStartDate.Location = new System.Drawing.Point(228, 143);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(88, 20);
            this.labelStartDate.TabIndex = 22;
            this.labelStartDate.Text = "Hire From : ";
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // labelHireTo
            // 
            this.labelHireTo.AutoSize = true;
            this.labelHireTo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHireTo.ForeColor = System.Drawing.Color.White;
            this.labelHireTo.Location = new System.Drawing.Point(228, 175);
            this.labelHireTo.Name = "labelHireTo";
            this.labelHireTo.Size = new System.Drawing.Size(64, 20);
            this.labelHireTo.TabIndex = 22;
            this.labelHireTo.Text = "Hire To: ";
            this.labelHireTo.Click += new System.EventHandler(this.labelHireTo_Click);
            // 
            // dtpHireFrom
            // 
            this.dtpHireFrom.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireFrom.Location = new System.Drawing.Point(322, 143);
            this.dtpHireFrom.Name = "dtpHireFrom";
            this.dtpHireFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpHireFrom.TabIndex = 2;
            this.dtpHireFrom.ValueChanged += new System.EventHandler(this.dtpHireFrom_ValueChanged);
            // 
            // dtpHireTo
            // 
            this.dtpHireTo.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireTo.Location = new System.Drawing.Point(322, 174);
            this.dtpHireTo.Name = "dtpHireTo";
            this.dtpHireTo.Size = new System.Drawing.Size(200, 20);
            this.dtpHireTo.TabIndex = 3;
            this.dtpHireTo.ValueChanged += new System.EventHandler(this.dtpHireTo_ValueChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(228, 201);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(63, 20);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Place : ";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // rtbPlace
            // 
            this.rtbPlace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPlace.Location = new System.Drawing.Point(322, 203);
            this.rtbPlace.Name = "rtbPlace";
            this.rtbPlace.Size = new System.Drawing.Size(200, 93);
            this.rtbPlace.TabIndex = 4;
            this.rtbPlace.Text = "";
            this.rtbPlace.TextChanged += new System.EventHandler(this.rtbPlace_TextChanged);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.Black;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.Orange;
            this.btnRequest.Location = new System.Drawing.Point(362, 316);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(106, 31);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // formHiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.rtbPlace);
            this.Controls.Add(this.dtpHireTo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.dtpHireFrom);
            this.Controls.Add(this.labelHireTo);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelHirePhotographer);
            this.Controls.Add(this.PhotographerInfoPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formHiring";
            this.Text = "Hire Photographer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formHiring_FormClosing);
            this.Load += new System.EventHandler(this.formHiring_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PhotographerInfoPanel.ResumeLayout(false);
            this.PhotographerInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotographerInfoPic)).EndInit();
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
        private System.Windows.Forms.Panel PhotographerInfoPanel;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelPhotographerInfo;
        private System.Windows.Forms.Label labelHirePhotographer;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelHireTo;
        private System.Windows.Forms.DateTimePicker dtpHireFrom;
        private System.Windows.Forms.DateTimePicker dtpHireTo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RichTextBox rtbPlace;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.PictureBox pbPhotographerInfoPic;
    }
}