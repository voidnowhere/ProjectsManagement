namespace ProjectsManagement.Forms
{
    partial class MembersManagementForm
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
            this.listViewMembers = new System.Windows.Forms.ListView();
            this.columnHeaderMemberId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNIC = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderIsActive = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.buttonChnageIsActive = new System.Windows.Forms.Button();
            this.listViewMemberCompetencies = new System.Windows.Forms.ListView();
            this.columnHeaderMCId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMCName = new System.Windows.Forms.ColumnHeader();
            this.listViewCompetencies = new System.Windows.Forms.ListView();
            this.columnHeaderCId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCName = new System.Windows.Forms.ColumnHeader();
            this.buttonAddCompetence = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRemoveCompetence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMembers
            // 
            this.listViewMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMemberId,
            this.columnHeaderLastName,
            this.columnHeaderFirstName,
            this.columnHeaderNIC,
            this.columnHeaderPhoneNumber,
            this.columnHeaderEmail,
            this.columnHeaderIsActive});
            this.listViewMembers.Location = new System.Drawing.Point(12, 123);
            this.listViewMembers.Name = "listViewMembers";
            this.listViewMembers.Size = new System.Drawing.Size(363, 241);
            this.listViewMembers.TabIndex = 0;
            this.listViewMembers.UseCompatibleStateImageBehavior = false;
            this.listViewMembers.View = System.Windows.Forms.View.Details;
            this.listViewMembers.SelectedIndexChanged += new System.EventHandler(this.listViewMembers_SelectedIndexChanged);
            // 
            // columnHeaderMemberId
            // 
            this.columnHeaderMemberId.Text = "Id";
            this.columnHeaderMemberId.Width = 0;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            // 
            // columnHeaderNIC
            // 
            this.columnHeaderNIC.Text = "NIC";
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Phone Number";
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            // 
            // columnHeaderIsActive
            // 
            this.columnHeaderIsActive.Text = "Active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(81, 12);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(81, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Location = new System.Drawing.Point(302, 12);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(100, 23);
            this.textBoxNIC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NIC";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(302, 41);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(81, 70);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(208, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(327, 70);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(595, 39);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Location = new System.Drawing.Point(489, 40);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(100, 23);
            this.buttonResetPassword.TabIndex = 14;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // buttonChnageIsActive
            // 
            this.buttonChnageIsActive.Location = new System.Drawing.Point(408, 40);
            this.buttonChnageIsActive.Name = "buttonChnageIsActive";
            this.buttonChnageIsActive.Size = new System.Drawing.Size(75, 23);
            this.buttonChnageIsActive.TabIndex = 15;
            this.buttonChnageIsActive.Text = "Activate";
            this.buttonChnageIsActive.UseVisualStyleBackColor = true;
            this.buttonChnageIsActive.Click += new System.EventHandler(this.buttonChnageIsActive_Click);
            // 
            // listViewMemberCompetencies
            // 
            this.listViewMemberCompetencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMCId,
            this.columnHeaderMCName});
            this.listViewMemberCompetencies.Location = new System.Drawing.Point(381, 123);
            this.listViewMemberCompetencies.Name = "listViewMemberCompetencies";
            this.listViewMemberCompetencies.Size = new System.Drawing.Size(134, 241);
            this.listViewMemberCompetencies.TabIndex = 16;
            this.listViewMemberCompetencies.UseCompatibleStateImageBehavior = false;
            this.listViewMemberCompetencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMCId
            // 
            this.columnHeaderMCId.Text = "Id";
            this.columnHeaderMCId.Width = 0;
            // 
            // columnHeaderMCName
            // 
            this.columnHeaderMCName.Text = "Name";
            this.columnHeaderMCName.Width = 100;
            // 
            // listViewCompetencies
            // 
            this.listViewCompetencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCId,
            this.columnHeaderCName});
            this.listViewCompetencies.Location = new System.Drawing.Point(558, 123);
            this.listViewCompetencies.Name = "listViewCompetencies";
            this.listViewCompetencies.Size = new System.Drawing.Size(130, 241);
            this.listViewCompetencies.TabIndex = 17;
            this.listViewCompetencies.UseCompatibleStateImageBehavior = false;
            this.listViewCompetencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCId
            // 
            this.columnHeaderCId.Width = 0;
            // 
            // columnHeaderCName
            // 
            this.columnHeaderCName.Text = "Name";
            this.columnHeaderCName.Width = 100;
            // 
            // buttonAddCompetence
            // 
            this.buttonAddCompetence.Location = new System.Drawing.Point(521, 208);
            this.buttonAddCompetence.Name = "buttonAddCompetence";
            this.buttonAddCompetence.Size = new System.Drawing.Size(31, 23);
            this.buttonAddCompetence.TabIndex = 18;
            this.buttonAddCompetence.Text = "<<";
            this.buttonAddCompetence.UseVisualStyleBackColor = true;
            this.buttonAddCompetence.Click += new System.EventHandler(this.buttonAddCompetence_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Members";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Member Competencies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Competencies";
            // 
            // buttonRemoveCompetence
            // 
            this.buttonRemoveCompetence.Location = new System.Drawing.Point(521, 237);
            this.buttonRemoveCompetence.Name = "buttonRemoveCompetence";
            this.buttonRemoveCompetence.Size = new System.Drawing.Size(31, 23);
            this.buttonRemoveCompetence.TabIndex = 22;
            this.buttonRemoveCompetence.Text = ">>";
            this.buttonRemoveCompetence.UseVisualStyleBackColor = true;
            this.buttonRemoveCompetence.Click += new System.EventHandler(this.buttonRemoveCompetence_Click);
            // 
            // MembersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 377);
            this.Controls.Add(this.buttonRemoveCompetence);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddCompetence);
            this.Controls.Add(this.listViewCompetencies);
            this.Controls.Add(this.listViewMemberCompetencies);
            this.Controls.Add(this.buttonChnageIsActive);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMembers);
            this.Name = "MembersManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members Management";
            this.Load += new System.EventHandler(this.MembersManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewMembers;
        private Label label1;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxNIC;
        private Label label3;
        private TextBox textBoxPhoneNumber;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label5;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonResetPassword;
        private Button buttonChnageIsActive;
        private ListView listViewMemberCompetencies;
        private ListView listViewCompetencies;
        private Button buttonAddCompetence;
        private Label label6;
        private Label label7;
        private Label label8;
        private ColumnHeader columnHeaderMemberId;
        private ColumnHeader columnHeaderLastName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderNIC;
        private ColumnHeader columnHeaderPhoneNumber;
        private ColumnHeader columnHeaderEmail;
        private ColumnHeader columnHeaderIsActive;
        private ColumnHeader columnHeaderMCId;
        private ColumnHeader columnHeaderMCName;
        private ColumnHeader columnHeaderCId;
        private ColumnHeader columnHeaderCName;
        private Button buttonRemoveCompetence;
    }
}