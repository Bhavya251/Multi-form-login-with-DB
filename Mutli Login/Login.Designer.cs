namespace Mutli_Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.mbtnLogin = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsername = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.Location = new System.Drawing.Point(266, 176);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(75, 23);
            this.mbtnLogin.TabIndex = 2;
            this.mbtnLogin.Text = "&Login";
            this.mbtnLogin.UseSelectable = true;
            this.mbtnLogin.UseStyleColors = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.DisplayIcon = true;
            this.mtxtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("mtxtPassword.Icon")));
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(146, 121);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.PromptText = "Enter password";
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(195, 23);
            this.mtxtPassword.TabIndex = 1;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.WaterMark = "Enter password";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPassword.TextChanged += new System.EventHandler(this.mtxtPassword_TextChanged);
            // 
            // mtxtUsername
            // 
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.DisplayIcon = true;
            this.mtxtUsername.Icon = global::Mutli_Login.Properties.Resources.user;
            this.mtxtUsername.Lines = new string[0];
            this.mtxtUsername.Location = new System.Drawing.Point(146, 82);
            this.mtxtUsername.MaxLength = 32767;
            this.mtxtUsername.Name = "mtxtUsername";
            this.mtxtUsername.PasswordChar = '\0';
            this.mtxtUsername.PromptText = "Enter user name";
            this.mtxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsername.SelectedText = "";
            this.mtxtUsername.SelectionLength = 0;
            this.mtxtUsername.SelectionStart = 0;
            this.mtxtUsername.ShortcutsEnabled = true;
            this.mtxtUsername.Size = new System.Drawing.Size(195, 23);
            this.mtxtUsername.TabIndex = 0;
            this.mtxtUsername.UseSelectable = true;
            this.mtxtUsername.WaterMark = "Enter user name";
            this.mtxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(364, 237);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.mtxtUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroButton mbtnLogin;
        private MetroFramework.Controls.MetroTextBox mtxtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

