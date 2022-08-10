namespace Inventar_2._0
{
    partial class LoginForm
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernamePanelLine = new System.Windows.Forms.Panel();
            this.passwordPanelLine = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.rememberMeBox = new System.Windows.Forms.CheckBox();
            this.autoLogInBox = new System.Windows.Forms.CheckBox();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.usernamePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameBox.Location = new System.Drawing.Point(77, 111);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(232, 18);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.TabStop = false;
            this.usernameBox.Text = "Brukernavn";
            this.usernameBox.Click += new System.EventHandler(this.usernameBox_Click);
            // 
            // usernamePanelLine
            // 
            this.usernamePanelLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernamePanelLine.ForeColor = System.Drawing.Color.Transparent;
            this.usernamePanelLine.Location = new System.Drawing.Point(47, 131);
            this.usernamePanelLine.Name = "usernamePanelLine";
            this.usernamePanelLine.Size = new System.Drawing.Size(262, 1);
            this.usernamePanelLine.TabIndex = 0;
            // 
            // passwordPanelLine
            // 
            this.passwordPanelLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordPanelLine.Location = new System.Drawing.Point(47, 175);
            this.passwordPanelLine.Name = "passwordPanelLine";
            this.passwordPanelLine.Size = new System.Drawing.Size(262, 1);
            this.passwordPanelLine.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordBox.Location = new System.Drawing.Point(77, 155);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(232, 18);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = "Passord";
            this.passwordBox.Click += new System.EventHandler(this.passwordBox_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.logInBtn.Location = new System.Drawing.Point(47, 200);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(262, 40);
            this.logInBtn.TabIndex = 3;
            this.logInBtn.TabStop = false;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 1);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Anders Hagås © Holmestrand Datasenter 2022";
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Location = new System.Drawing.Point(298, 311);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(42, 15);
            this.versionText.TabIndex = 8;
            this.versionText.Text = "v0.0.0.1";
            // 
            // rememberMeBox
            // 
            this.rememberMeBox.AutoSize = true;
            this.rememberMeBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeBox.ForeColor = System.Drawing.Color.White;
            this.rememberMeBox.Location = new System.Drawing.Point(47, 246);
            this.rememberMeBox.Name = "rememberMeBox";
            this.rememberMeBox.Size = new System.Drawing.Size(81, 19);
            this.rememberMeBox.TabIndex = 9;
            this.rememberMeBox.Text = "Husk Meg";
            this.rememberMeBox.UseVisualStyleBackColor = true;
            // 
            // autoLogInBox
            // 
            this.autoLogInBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLogInBox.ForeColor = System.Drawing.Color.White;
            this.autoLogInBox.Location = new System.Drawing.Point(134, 246);
            this.autoLogInBox.Name = "autoLogInBox";
            this.autoLogInBox.Size = new System.Drawing.Size(92, 20);
            this.autoLogInBox.TabIndex = 10;
            this.autoLogInBox.Text = "Auto-log in";
            this.autoLogInBox.UseVisualStyleBackColor = true;
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = global::Inventar_2._0.Properties.Resources.password;
            this.passwordPicture.Location = new System.Drawing.Point(47, 148);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(24, 24);
            this.passwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordPicture.TabIndex = 5;
            this.passwordPicture.TabStop = false;
            // 
            // usernamePicture
            // 
            this.usernamePicture.Image = global::Inventar_2._0.Properties.Resources.username;
            this.usernamePicture.Location = new System.Drawing.Point(47, 104);
            this.usernamePicture.Name = "usernamePicture";
            this.usernamePicture.Size = new System.Drawing.Size(24, 24);
            this.usernamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernamePicture.TabIndex = 2;
            this.usernamePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventar_2._0.Properties.Resources.H_Logo_003EFF_blue_med_text_height_75;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(352, 332);
            this.Controls.Add(this.autoLogInBox);
            this.Controls.Add(this.rememberMeBox);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordPanelLine);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.usernamePanelLine);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernamePicture);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox usernamePicture;
        private System.Windows.Forms.Panel usernamePanelLine;
        private System.Windows.Forms.Panel passwordPanelLine;
        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.CheckBox rememberMeBox;
        private System.Windows.Forms.CheckBox autoLogInBox;
    }
}

