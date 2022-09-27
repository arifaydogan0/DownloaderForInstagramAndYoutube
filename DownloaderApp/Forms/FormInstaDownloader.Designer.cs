namespace DownloaderApp.Forms
{
    partial class FormInstaDownloader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.loginStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.comboboxLinkDownload = new System.Windows.Forms.ComboBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPrgrs = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginStatus);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İnsta Account";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(6, 57);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(164, 26);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 120);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(164, 26);
            this.textBoxPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(7, 175);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(163, 28);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // loginStatus
            // 
            this.loginStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginStatus.BackColor = System.Drawing.Color.White;
            this.loginStatus.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStatus.Location = new System.Drawing.Point(6, 263);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(164, 35);
            this.loginStatus.TabIndex = 39;
            this.loginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.labelPrgrs);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Controls.Add(this.buttonGet);
            this.groupBox2.Controls.Add(this.labelLocation);
            this.groupBox2.Controls.Add(this.labelPosts);
            this.groupBox2.Controls.Add(this.labelUrl);
            this.groupBox2.Controls.Add(this.txtUrl);
            this.groupBox2.Controls.Add(this.txtSaveLocation);
            this.groupBox2.Controls.Add(this.comboboxLinkDownload);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(232, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUrl.Location = new System.Drawing.Point(97, 56);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrl.Size = new System.Drawing.Size(448, 26);
            this.txtUrl.TabIndex = 22;
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveLocation.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSaveLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSaveLocation.Location = new System.Drawing.Point(97, 124);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(448, 26);
            this.txtSaveLocation.TabIndex = 23;
            // 
            // comboboxLinkDownload
            // 
            this.comboboxLinkDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxLinkDownload.BackColor = System.Drawing.Color.Gainsboro;
            this.comboboxLinkDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxLinkDownload.FormattingEnabled = true;
            this.comboboxLinkDownload.Location = new System.Drawing.Point(97, 89);
            this.comboboxLinkDownload.Name = "comboboxLinkDownload";
            this.comboboxLinkDownload.Size = new System.Drawing.Size(448, 28);
            this.comboboxLinkDownload.TabIndex = 24;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(9, 59);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(29, 20);
            this.labelUrl.TabIndex = 25;
            this.labelUrl.Text = "Url";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(9, 97);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(49, 20);
            this.labelPosts.TabIndex = 25;
            this.labelPosts.Text = "Posts";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(9, 130);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(49, 20);
            this.labelLocation.TabIndex = 25;
            this.labelLocation.Text = "Save ";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(97, 174);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(202, 28);
            this.buttonGet.TabIndex = 26;
            this.buttonGet.Text = "GET";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(338, 174);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(207, 28);
            this.buttonStart.TabIndex = 26;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(97, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(412, 20);
            this.progressBar1.TabIndex = 27;
            // 
            // labelPrgrs
            // 
            this.labelPrgrs.AutoSize = true;
            this.labelPrgrs.BackColor = System.Drawing.Color.Transparent;
            this.labelPrgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrgrs.Location = new System.Drawing.Point(512, 278);
            this.labelPrgrs.Name = "labelPrgrs";
            this.labelPrgrs.Size = new System.Drawing.Size(29, 18);
            this.labelPrgrs.TabIndex = 28;
            this.labelPrgrs.Text = "0%";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.Location = new System.Drawing.Point(64, 123);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 29);
            this.btnBrowse.TabIndex = 29;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FormInstaDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInstaDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInstaDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInstaDownloader_FormClosing);
            this.Load += new System.EventHandler(this.FormInstaDownloader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label loginStatus;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPrgrs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtSaveLocation;
        public System.Windows.Forms.ComboBox comboboxLinkDownload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}