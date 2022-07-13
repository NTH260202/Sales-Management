namespace PRN211PE_SU22_NguyenThanhHa_Presentation
{
    partial class MemberForm
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
            this.groupMember = new System.Windows.Forms.GroupBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.Label();
            this.intMemberId = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.memberGridView = new System.Windows.Forms.DataGridView();
            this.tblMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.MemberIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupMember
            // 
            this.groupMember.Controls.Add(this.txtCompanyName);
            this.groupMember.Controls.Add(this.txtMemberId);
            this.groupMember.Controls.Add(this.CompanyName);
            this.groupMember.Controls.Add(this.intMemberId);
            this.groupMember.Controls.Add(this.Country);
            this.groupMember.Controls.Add(this.txtCountry);
            this.groupMember.Controls.Add(this.txtCity);
            this.groupMember.Controls.Add(this.City);
            this.groupMember.Controls.Add(this.txtPassword);
            this.groupMember.Controls.Add(this.Password);
            this.groupMember.Controls.Add(this.memberGridView);
            this.groupMember.Controls.Add(this.txtEmail);
            this.groupMember.Controls.Add(this.Email);
            this.groupMember.Location = new System.Drawing.Point(40, 43);
            this.groupMember.Name = "groupMember";
            this.groupMember.Size = new System.Drawing.Size(814, 499);
            this.groupMember.TabIndex = 0;
            this.groupMember.TabStop = false;
            this.groupMember.Text = "MemberList";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(130, 89);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(125, 27);
            this.txtCompanyName.TabIndex = 12;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(130, 31);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(125, 27);
            this.txtMemberId.TabIndex = 11;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(14, 96);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(112, 20);
            this.CompanyName.TabIndex = 10;
            this.CompanyName.Text = "CompanyName";
            // 
            // intMemberId
            // 
            this.intMemberId.AutoSize = true;
            this.intMemberId.Location = new System.Drawing.Point(14, 38);
            this.intMemberId.Name = "intMemberId";
            this.intMemberId.Size = new System.Drawing.Size(82, 20);
            this.intMemberId.TabIndex = 9;
            this.intMemberId.Text = "Member Id";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(546, 96);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(60, 20);
            this.Country.TabIndex = 8;
            this.Country.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(625, 89);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(125, 27);
            this.txtCountry.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(625, 31);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 27);
            this.txtCity.TabIndex = 6;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(546, 38);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(34, 20);
            this.City.TabIndex = 5;
            this.City.Text = "City";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(370, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(294, 96);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // memberGridView
            // 
            this.memberGridView.AutoGenerateColumns = false;
            this.memberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberIdColumn,
            this.PasswordColumn,
            this.EmailColumn,
            this.CompanyNameColumn,
            this.CityColumn,
            this.CountryColumn});
            this.memberGridView.DataSource = this.tblMemberBindingSource;
            this.memberGridView.Location = new System.Drawing.Point(14, 180);
            this.memberGridView.Name = "memberGridView";
            this.memberGridView.RowHeadersWidth = 51;
            this.memberGridView.RowTemplate.Height = 29;
            this.memberGridView.Size = new System.Drawing.Size(781, 313);
            this.memberGridView.TabIndex = 2;
            this.memberGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberGridView1_CellClick);
            this.memberGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberGridView1_CellContentClick);
            // 
            // tblMemberBindingSource
            // 
            this.tblMemberBindingSource.DataSource = typeof(BusinessObject.TblMember);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(370, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(294, 34);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(874, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(874, 56);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(874, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(874, 223);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // MemberIdColumn
            // 
            this.MemberIdColumn.DataPropertyName = "MemberId";
            this.MemberIdColumn.HeaderText = "MemberId";
            this.MemberIdColumn.MinimumWidth = 6;
            this.MemberIdColumn.Name = "MemberIdColumn";
            this.MemberIdColumn.Width = 125;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.MinimumWidth = 6;
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.Width = 125;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 125;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "CompanyName";
            this.CompanyNameColumn.MinimumWidth = 6;
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.Width = 125;
            // 
            // CityColumn
            // 
            this.CityColumn.DataPropertyName = "City";
            this.CityColumn.HeaderText = "City";
            this.CityColumn.MinimumWidth = 6;
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.Width = 125;
            // 
            // CountryColumn
            // 
            this.CountryColumn.DataPropertyName = "Country";
            this.CountryColumn.HeaderText = "Country";
            this.CountryColumn.MinimumWidth = 6;
            this.CountryColumn.Name = "CountryColumn";
            this.CountryColumn.Width = 125;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 567);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupMember);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.groupMember.ResumeLayout(false);
            this.groupMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupMember;
        private DataGridView memberGridView;
        private TextBox txtEmail;
        private Label Email;
        private Label Country;
        private TextBox txtCountry;
        private TextBox txtCity;
        private Label City;
        private TextBox txtPassword;
        private Label Password;
        private BindingSource tblMemberBindingSource;
        private TextBox txtMemberId;
        private Label CompanyName;
        private Label intMemberId;
        private TextBox txtCompanyName;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnNew;
        private DataGridViewTextBoxColumn MemberIdColumn;
        private DataGridViewTextBoxColumn PasswordColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private DataGridViewTextBoxColumn CompanyNameColumn;
        private DataGridViewTextBoxColumn CityColumn;
        private DataGridViewTextBoxColumn CountryColumn;
    }
}