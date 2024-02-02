
namespace MyStoreWinApp
{
    partial class frmMemberManagements
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboSearchCountry = new System.Windows.Forms.ComboBox();
            cboSearchCity = new System.Windows.Forms.ComboBox();
            lbMemberID = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            cboCity = new System.Windows.Forms.ComboBox();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            cboCountry = new System.Windows.Forms.ComboBox();
            btnFind = new System.Windows.Forms.Button();
            lbsearch = new System.Windows.Forms.Label();
            lbFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // cboSearchCountry
            // 
            cboSearchCountry.FormattingEnabled = true;
            cboSearchCountry.Items.AddRange(new object[] { "United State", "Viet Nam", "America", "United Kingdom" });
            cboSearchCountry.Location = new System.Drawing.Point(142, 259);
            cboSearchCountry.Name = "cboSearchCountry";
            cboSearchCountry.Size = new System.Drawing.Size(211, 28);
            cboSearchCountry.TabIndex = 19;
            cboSearchCountry.Text = "Country";
            cboSearchCountry.SelectedIndexChanged += cboSearchCountry_SelectedIndexChanged;
            // 
            // cboSearchCity
            // 
            cboSearchCity.FormattingEnabled = true;
            cboSearchCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboSearchCity.Location = new System.Drawing.Point(414, 260);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new System.Drawing.Size(215, 28);
            cboSearchCity.TabIndex = 21;
            cboSearchCity.Text = "City";
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(58, 23);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(58, 117);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(58, 72);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(109, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(414, 75);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 3;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(414, 121);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(414, 23);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(501, 23);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(250, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(171, 23);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(219, 27);
            txtMemberID.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(169, 72);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(219, 27);
            txtMemberName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(171, 117);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new System.Drawing.Size(219, 27);
            txtPassword.TabIndex = 10;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboCity.Location = new System.Drawing.Point(501, 117);
            cboCity.Name = "cboCity";
            cboCity.Size = new System.Drawing.Size(250, 28);
            cboCity.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(605, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(354, 173);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(106, 173);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(354, 508);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 15;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(11, 293);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(777, 168);
            dgvMemberList.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            txtSearch.Location = new System.Drawing.Point(142, 211);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ID or Name";
            txtSearch.Size = new System.Drawing.Size(487, 27);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(695, 208);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "America", "United State", "United Kingdom" });
            cboCountry.Location = new System.Drawing.Point(501, 75);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new System.Drawing.Size(250, 28);
            cboCountry.TabIndex = 20;
            // 
            // btnFind
            // 
            btnFind.Location = new System.Drawing.Point(695, 259);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(94, 29);
            btnFind.TabIndex = 22;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lbsearch
            // 
            lbsearch.AutoSize = true;
            lbsearch.Location = new System.Drawing.Point(58, 214);
            lbsearch.Name = "lbsearch";
            lbsearch.Size = new System.Drawing.Size(73, 20);
            lbsearch.TabIndex = 23;
            lbsearch.Text = "Search by";
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Location = new System.Drawing.Point(58, 263);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new System.Drawing.Size(42, 20);
            lbFilter.TabIndex = 24;
            lbFilter.Text = "Filter";
            // 
            // frmMemberManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(814, 568);
            Controls.Add(lbFilter);
            Controls.Add(lbsearch);
            Controls.Add(btnFind);
            Controls.Add(cboSearchCity);
            Controls.Add(cboCountry);
            Controls.Add(cboSearchCountry);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(cboCity);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberID);
            Name = "frmMemberManagements";
            Text = "Member Management";
            Load += frmMemberManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbsearch;
        private System.Windows.Forms.Label lbFilter;
    }
}

