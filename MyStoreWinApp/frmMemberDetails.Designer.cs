
namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            lbMemberID = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            cboCity = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            cboCountry = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(178, 25);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(178, 77);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(109, 20);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(178, 141);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(178, 197);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(178, 319);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(178, 255);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(343, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(290, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(343, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(290, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(343, 77);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(290, 27);
            txtMemberName.TabIndex = 9;
            // 
            // txtMemberID
            // 
            txtMemberID.Enabled = false;
            txtMemberID.Location = new System.Drawing.Point(343, 25);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(290, 27);
            txtMemberID.TabIndex = 10;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboCity.Location = new System.Drawing.Point(343, 319);
            cboCity.Name = "cboCity";
            cboCity.Size = new System.Drawing.Size(290, 28);
            cboCity.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(343, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(539, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "America", "United State", "United Kingdom" });
            cboCountry.Location = new System.Drawing.Point(343, 252);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new System.Drawing.Size(290, 28);
            cboCountry.TabIndex = 15;
            // 
            // frmMemberDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(800, 451);
            Controls.Add(cboCountry);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCity);
            Controls.Add(txtMemberID);
            Controls.Add(txtMemberName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Name = "frmMemberDetails";
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboCountry;
    }
}