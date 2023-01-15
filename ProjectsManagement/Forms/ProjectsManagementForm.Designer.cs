namespace ProjectsManagement.Forms
{
    partial class ProjectsManagementForm
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
            this.listViewProjects = new System.Windows.Forms.ListView();
            this.columnHeaderPrjectId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProjectName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProjectProgress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProjectType = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProjectIsActive = new System.Windows.Forms.ColumnHeader();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProjectType = new System.Windows.Forms.ComboBox();
            this.listViewProjectMembers = new System.Windows.Forms.ListView();
            this.columnHeaderPMId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPMFullName = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewQualifiedMembers = new System.Windows.Forms.ListView();
            this.columnHeaderMemberId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMemberFullName = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonChangeIsActive = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonRemoveMember = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProjects
            // 
            this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPrjectId,
            this.columnHeaderProjectName,
            this.columnHeaderProjectProgress,
            this.columnHeaderProjectType,
            this.columnHeaderProjectIsActive});
            this.listViewProjects.Location = new System.Drawing.Point(12, 205);
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.Size = new System.Drawing.Size(350, 181);
            this.listViewProjects.TabIndex = 0;
            this.listViewProjects.UseCompatibleStateImageBehavior = false;
            this.listViewProjects.View = System.Windows.Forms.View.Details;
            this.listViewProjects.SelectedIndexChanged += new System.EventHandler(this.listViewProjects_SelectedIndexChanged);
            // 
            // columnHeaderPrjectId
            // 
            this.columnHeaderPrjectId.Text = "Id";
            this.columnHeaderPrjectId.Width = 0;
            // 
            // columnHeaderProjectName
            // 
            this.columnHeaderProjectName.Text = "Name";
            this.columnHeaderProjectName.Width = 150;
            // 
            // columnHeaderProjectProgress
            // 
            this.columnHeaderProjectProgress.Text = "Progress";
            // 
            // columnHeaderProjectType
            // 
            this.columnHeaderProjectType.Text = "Type";
            // 
            // columnHeaderProjectIsActive
            // 
            this.columnHeaderProjectIsActive.Text = "Active";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(277, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(85, 70);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(277, 80);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(85, 156);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // comboBoxProjectType
            // 
            this.comboBoxProjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjectType.FormattingEnabled = true;
            this.comboBoxProjectType.Location = new System.Drawing.Point(85, 41);
            this.comboBoxProjectType.Name = "comboBoxProjectType";
            this.comboBoxProjectType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxProjectType.TabIndex = 7;
            // 
            // listViewProjectMembers
            // 
            this.listViewProjectMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPMId,
            this.columnHeaderPMFullName});
            this.listViewProjectMembers.Location = new System.Drawing.Point(368, 205);
            this.listViewProjectMembers.Name = "listViewProjectMembers";
            this.listViewProjectMembers.Size = new System.Drawing.Size(121, 181);
            this.listViewProjectMembers.TabIndex = 9;
            this.listViewProjectMembers.UseCompatibleStateImageBehavior = false;
            this.listViewProjectMembers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPMId
            // 
            this.columnHeaderPMId.Text = "Id";
            this.columnHeaderPMId.Width = 0;
            // 
            // columnHeaderPMFullName
            // 
            this.columnHeaderPMFullName.Text = "Full Name";
            this.columnHeaderPMFullName.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Projects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Project Members";
            // 
            // listViewQualifiedMembers
            // 
            this.listViewQualifiedMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMemberId,
            this.columnHeaderMemberFullName});
            this.listViewQualifiedMembers.Location = new System.Drawing.Point(532, 205);
            this.listViewQualifiedMembers.Name = "listViewQualifiedMembers";
            this.listViewQualifiedMembers.Size = new System.Drawing.Size(121, 181);
            this.listViewQualifiedMembers.TabIndex = 12;
            this.listViewQualifiedMembers.UseCompatibleStateImageBehavior = false;
            this.listViewQualifiedMembers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMemberId
            // 
            this.columnHeaderMemberId.Width = 0;
            // 
            // columnHeaderMemberFullName
            // 
            this.columnHeaderMemberFullName.Text = "Full Name";
            this.columnHeaderMemberFullName.Width = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Qualified Members";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(464, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(464, 67);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonChangeIsActive
            // 
            this.buttonChangeIsActive.Location = new System.Drawing.Point(464, 96);
            this.buttonChangeIsActive.Name = "buttonChangeIsActive";
            this.buttonChangeIsActive.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeIsActive.TabIndex = 16;
            this.buttonChangeIsActive.Text = "Activate";
            this.buttonChangeIsActive.UseVisualStyleBackColor = true;
            this.buttonChangeIsActive.Click += new System.EventHandler(this.buttonChangeIsActive_Click);
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(495, 269);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(31, 23);
            this.buttonAddMember.TabIndex = 17;
            this.buttonAddMember.Text = "<<";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonRemoveMember
            // 
            this.buttonRemoveMember.Location = new System.Drawing.Point(495, 298);
            this.buttonRemoveMember.Name = "buttonRemoveMember";
            this.buttonRemoveMember.Size = new System.Drawing.Size(31, 23);
            this.buttonRemoveMember.TabIndex = 18;
            this.buttonRemoveMember.Text = ">>";
            this.buttonRemoveMember.UseVisualStyleBackColor = true;
            this.buttonRemoveMember.Click += new System.EventHandler(this.buttonRemoveMember_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(464, 125);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ProjectsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 396);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRemoveMember);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonChangeIsActive);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewQualifiedMembers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewProjectMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProjectType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listViewProjects);
            this.Name = "ProjectsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects Management";
            this.Load += new System.EventHandler(this.ProjectsManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewProjects;
        private Label labelName;
        private TextBox textBoxName;
        private RichTextBox richTextBoxDescription;
        private Label label1;
        private ComboBox comboBoxStatus;
        private Label label2;
        private ColumnHeader columnHeaderPrjectId;
        private ColumnHeader columnHeaderProjectName;
        private ColumnHeader columnHeaderProjectProgress;
        private ColumnHeader columnHeaderProjectType;
        private ColumnHeader columnHeaderProjectIsActive;
        private Label label3;
        private ComboBox comboBoxProjectType;
        private ListView listViewProjectMembers;
        private Label label4;
        private Label label5;
        private ListView listViewQualifiedMembers;
        private Label label6;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonChangeIsActive;
        private Button buttonAddMember;
        private Button buttonRemoveMember;
        private Button buttonDelete;
        private ColumnHeader columnHeaderPMId;
        private ColumnHeader columnHeaderPMFullName;
        private ColumnHeader columnHeaderMemberId;
        private ColumnHeader columnHeaderMemberFullName;
    }
}