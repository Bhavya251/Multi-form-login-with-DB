namespace Mutli_Login
{
    partial class Next
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Next));
            this.mlblCheckPassword = new MetroFramework.Controls.MetroLabel();
            this.mtlUpdate = new MetroFramework.Controls.MetroTile();
            this.mtxtContact = new System.Windows.Forms.MaskedTextBox();
            this.mlblSBirth = new MetroFramework.Controls.MetroLabel();
            this.mlblSPassword = new MetroFramework.Controls.MetroLabel();
            this.mlblSUsername = new MetroFramework.Controls.MetroLabel();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.mlblContact = new MetroFramework.Controls.MetroLabel();
            this.mlblEmail = new MetroFramework.Controls.MetroLabel();
            this.mlblFullName = new MetroFramework.Controls.MetroLabel();
            this.mtxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.mtxtName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mbtnChange = new MetroFramework.Controls.MetroButton();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.mtxtbday = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mtlDashboard = new MetroFramework.Controls.MetroTile();
            this.mtlAddUser = new MetroFramework.Controls.MetroTile();
            this.mtlEdit = new MetroFramework.Controls.MetroTile();
            this.mtlLogout = new MetroFramework.Controls.MetroTile();
            this.mtlStock = new MetroFramework.Controls.MetroTile();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new Mutli_Login.LoginDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Mutli_Login.LoginDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblCheckPassword
            // 
            this.mlblCheckPassword.AutoSize = true;
            this.mlblCheckPassword.Location = new System.Drawing.Point(464, 527);
            this.mlblCheckPassword.Name = "mlblCheckPassword";
            this.mlblCheckPassword.Size = new System.Drawing.Size(0, 0);
            this.mlblCheckPassword.TabIndex = 37;
            // 
            // mtlUpdate
            // 
            this.mtlUpdate.ActiveControl = null;
            this.mtlUpdate.Location = new System.Drawing.Point(3, 210);
            this.mtlUpdate.Name = "mtlUpdate";
            this.mtlUpdate.Size = new System.Drawing.Size(104, 63);
            this.mtlUpdate.TabIndex = 42;
            this.mtlUpdate.Text = "Update";
            this.mtlUpdate.UseSelectable = true;
            this.mtlUpdate.Click += new System.EventHandler(this.mtlUpdate_Click);
            // 
            // mtxtContact
            // 
            this.mtxtContact.Location = new System.Drawing.Point(275, 334);
            this.mtxtContact.Mask = "0000000000";
            this.mtxtContact.Name = "mtxtContact";
            this.mtxtContact.Size = new System.Drawing.Size(113, 20);
            this.mtxtContact.TabIndex = 45;
            // 
            // mlblSBirth
            // 
            this.mlblSBirth.AutoSize = true;
            this.mlblSBirth.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblSBirth.Location = new System.Drawing.Point(158, 371);
            this.mlblSBirth.Name = "mlblSBirth";
            this.mlblSBirth.Size = new System.Drawing.Size(65, 19);
            this.mlblSBirth.TabIndex = 56;
            this.mlblSBirth.Text = "Birthdate";
            // 
            // mlblSPassword
            // 
            this.mlblSPassword.AutoSize = true;
            this.mlblSPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblSPassword.Location = new System.Drawing.Point(158, 444);
            this.mlblSPassword.Name = "mlblSPassword";
            this.mlblSPassword.Size = new System.Drawing.Size(67, 19);
            this.mlblSPassword.TabIndex = 54;
            this.mlblSPassword.Text = "Password";
            // 
            // mlblSUsername
            // 
            this.mlblSUsername.AutoSize = true;
            this.mlblSUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblSUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mlblSUsername.Location = new System.Drawing.Point(158, 406);
            this.mlblSUsername.Name = "mlblSUsername";
            this.mlblSUsername.Size = new System.Drawing.Size(71, 19);
            this.mlblSUsername.TabIndex = 53;
            this.mlblSUsername.Text = "Username";
            this.mlblSUsername.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(275, 442);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '\0';
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(200, 23);
            this.mtxtPassword.TabIndex = 48;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUsername
            // 
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.Lines = new string[0];
            this.mtxtUsername.Location = new System.Drawing.Point(275, 405);
            this.mtxtUsername.MaxLength = 32767;
            this.mtxtUsername.Name = "mtxtUsername";
            this.mtxtUsername.PasswordChar = '\0';
            this.mtxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsername.SelectedText = "";
            this.mtxtUsername.SelectionLength = 0;
            this.mtxtUsername.SelectionStart = 0;
            this.mtxtUsername.ShortcutsEnabled = true;
            this.mtxtUsername.Size = new System.Drawing.Size(200, 23);
            this.mtxtUsername.TabIndex = 47;
            this.mtxtUsername.UseSelectable = true;
            this.mtxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblContact
            // 
            this.mlblContact.AutoSize = true;
            this.mlblContact.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblContact.Location = new System.Drawing.Point(158, 335);
            this.mlblContact.Name = "mlblContact";
            this.mlblContact.Size = new System.Drawing.Size(82, 19);
            this.mlblContact.TabIndex = 52;
            this.mlblContact.Text = "Contact No.";
            // 
            // mlblEmail
            // 
            this.mlblEmail.AutoSize = true;
            this.mlblEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEmail.Location = new System.Drawing.Point(158, 297);
            this.mlblEmail.Name = "mlblEmail";
            this.mlblEmail.Size = new System.Drawing.Size(59, 19);
            this.mlblEmail.TabIndex = 51;
            this.mlblEmail.Text = "Email ID";
            // 
            // mlblFullName
            // 
            this.mlblFullName.AutoSize = true;
            this.mlblFullName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblFullName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mlblFullName.Location = new System.Drawing.Point(158, 261);
            this.mlblFullName.Name = "mlblFullName";
            this.mlblFullName.Size = new System.Drawing.Size(70, 19);
            this.mlblFullName.TabIndex = 50;
            this.mlblFullName.Text = "Full Name";
            this.mlblFullName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mtxtEmail
            // 
            // 
            // 
            // 
            this.mtxtEmail.CustomButton.Image = null;
            this.mtxtEmail.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.mtxtEmail.CustomButton.Name = "";
            this.mtxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtEmail.CustomButton.TabIndex = 1;
            this.mtxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtEmail.CustomButton.UseSelectable = true;
            this.mtxtEmail.CustomButton.Visible = false;
            this.mtxtEmail.Lines = new string[0];
            this.mtxtEmail.Location = new System.Drawing.Point(275, 296);
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.SelectionLength = 0;
            this.mtxtEmail.SelectionStart = 0;
            this.mtxtEmail.ShortcutsEnabled = true;
            this.mtxtEmail.Size = new System.Drawing.Size(301, 23);
            this.mtxtEmail.TabIndex = 44;
            this.mtxtEmail.UseSelectable = true;
            this.mtxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtName
            // 
            // 
            // 
            // 
            this.mtxtName.CustomButton.Image = null;
            this.mtxtName.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.mtxtName.CustomButton.Name = "";
            this.mtxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtName.CustomButton.TabIndex = 1;
            this.mtxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtName.CustomButton.UseSelectable = true;
            this.mtxtName.CustomButton.Visible = false;
            this.mtxtName.Lines = new string[0];
            this.mtxtName.Location = new System.Drawing.Point(275, 259);
            this.mtxtName.MaxLength = 32767;
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.PasswordChar = '\0';
            this.mtxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtName.SelectedText = "";
            this.mtxtName.SelectionLength = 0;
            this.mtxtName.SelectionStart = 0;
            this.mtxtName.ShortcutsEnabled = true;
            this.mtxtName.Size = new System.Drawing.Size(301, 23);
            this.mtxtName.TabIndex = 43;
            this.mtxtName.UseSelectable = true;
            this.mtxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(355, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 220);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 57;
            this.pictureBox.TabStop = false;
            // 
            // mbtnChange
            // 
            this.mbtnChange.Location = new System.Drawing.Point(242, 207);
            this.mbtnChange.Name = "mbtnChange";
            this.mbtnChange.Size = new System.Drawing.Size(86, 30);
            this.mbtnChange.TabIndex = 58;
            this.mbtnChange.Text = "Change";
            this.mbtnChange.UseSelectable = true;
            this.mbtnChange.Visible = false;
            this.mbtnChange.Click += new System.EventHandler(this.mbtnChange_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openImage";
            // 
            // mtxtbday
            // 
            // 
            // 
            // 
            this.mtxtbday.CustomButton.Image = null;
            this.mtxtbday.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.mtxtbday.CustomButton.Name = "";
            this.mtxtbday.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtbday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtbday.CustomButton.TabIndex = 1;
            this.mtxtbday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtbday.CustomButton.UseSelectable = true;
            this.mtxtbday.CustomButton.Visible = false;
            this.mtxtbday.Lines = new string[0];
            this.mtxtbday.Location = new System.Drawing.Point(275, 370);
            this.mtxtbday.MaxLength = 32767;
            this.mtxtbday.Name = "mtxtbday";
            this.mtxtbday.PasswordChar = '\0';
            this.mtxtbday.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtbday.SelectedText = "";
            this.mtxtbday.SelectionLength = 0;
            this.mtxtbday.SelectionStart = 0;
            this.mtxtbday.ShortcutsEnabled = true;
            this.mtxtbday.Size = new System.Drawing.Size(113, 23);
            this.mtxtbday.TabIndex = 59;
            this.mtxtbday.UseSelectable = true;
            this.mtxtbday.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtbday.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mtlDashboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtlAddUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtlEdit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mtlUpdate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtlLogout, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtlStock, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(110, 409);
            this.tableLayoutPanel1.TabIndex = 60;
            // 
            // mtlDashboard
            // 
            this.mtlDashboard.ActiveControl = null;
            this.mtlDashboard.Location = new System.Drawing.Point(3, 3);
            this.mtlDashboard.Name = "mtlDashboard";
            this.mtlDashboard.Size = new System.Drawing.Size(104, 63);
            this.mtlDashboard.TabIndex = 43;
            this.mtlDashboard.Text = "Dashboard";
            this.mtlDashboard.UseSelectable = true;
            // 
            // mtlAddUser
            // 
            this.mtlAddUser.ActiveControl = null;
            this.mtlAddUser.Location = new System.Drawing.Point(3, 72);
            this.mtlAddUser.Name = "mtlAddUser";
            this.mtlAddUser.Size = new System.Drawing.Size(104, 63);
            this.mtlAddUser.TabIndex = 42;
            this.mtlAddUser.Text = "Add User";
            this.mtlAddUser.UseSelectable = true;
            this.mtlAddUser.Click += new System.EventHandler(this.mtlAddUser_Click);
            // 
            // mtlEdit
            // 
            this.mtlEdit.ActiveControl = null;
            this.mtlEdit.Location = new System.Drawing.Point(3, 141);
            this.mtlEdit.Name = "mtlEdit";
            this.mtlEdit.Size = new System.Drawing.Size(104, 63);
            this.mtlEdit.TabIndex = 42;
            this.mtlEdit.Text = "Edit";
            this.mtlEdit.UseSelectable = true;
            this.mtlEdit.Click += new System.EventHandler(this.mtlEdit_Click);
            // 
            // mtlLogout
            // 
            this.mtlLogout.ActiveControl = null;
            this.mtlLogout.Location = new System.Drawing.Point(3, 348);
            this.mtlLogout.Name = "mtlLogout";
            this.mtlLogout.Size = new System.Drawing.Size(104, 58);
            this.mtlLogout.TabIndex = 42;
            this.mtlLogout.Text = "Logout";
            this.mtlLogout.UseSelectable = true;
            this.mtlLogout.Click += new System.EventHandler(this.mtlLogout_Click);
            // 
            // mtlStock
            // 
            this.mtlStock.ActiveControl = null;
            this.mtlStock.Location = new System.Drawing.Point(3, 279);
            this.mtlStock.Name = "mtlStock";
            this.mtlStock.Size = new System.Drawing.Size(104, 63);
            this.mtlStock.TabIndex = 44;
            this.mtlStock.Text = "Update Stock";
            this.mtlStock.UseSelectable = true;
            this.mtlStock.Click += new System.EventHandler(this.mtlStock_Click);
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.loginDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Next
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(598, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mtxtbday);
            this.Controls.Add(this.mbtnChange);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mtxtContact);
            this.Controls.Add(this.mlblSBirth);
            this.Controls.Add(this.mlblSPassword);
            this.Controls.Add(this.mlblSUsername);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.mtxtUsername);
            this.Controls.Add(this.mlblContact);
            this.Controls.Add(this.mlblEmail);
            this.Controls.Add(this.mlblFullName);
            this.Controls.Add(this.mtxtEmail);
            this.Controls.Add(this.mtxtName);
            this.Controls.Add(this.mlblCheckPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Next";
            this.Load += new System.EventHandler(this.Next_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mlblCheckPassword;
        //private LoginDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private LoginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LoginDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private MetroFramework.Controls.MetroTile mtlUpdate;
        private System.Windows.Forms.MaskedTextBox mtxtContact;
        private MetroFramework.Controls.MetroLabel mlblSBirth;
        private MetroFramework.Controls.MetroLabel mlblSPassword;
        private MetroFramework.Controls.MetroLabel mlblSUsername;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroTextBox mtxtUsername;
        private MetroFramework.Controls.MetroLabel mlblContact;
        private MetroFramework.Controls.MetroLabel mlblEmail;
        private MetroFramework.Controls.MetroLabel mlblFullName;
        private MetroFramework.Controls.MetroTextBox mtxtEmail;
        private MetroFramework.Controls.MetroTextBox mtxtName;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroButton mbtnChange;
        private System.Windows.Forms.OpenFileDialog openImage;
        private MetroFramework.Controls.MetroTextBox mtxtbday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile mtlDashboard;
        private MetroFramework.Controls.MetroTile mtlEdit;
        private MetroFramework.Controls.MetroTile mtlAddUser;
        private MetroFramework.Controls.MetroTile mtlLogout;
        private MetroFramework.Controls.MetroTile mtlStock;
    }
}