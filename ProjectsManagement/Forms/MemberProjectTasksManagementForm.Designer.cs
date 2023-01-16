namespace ProjectsManagement.Forms
{
    partial class MemberProjectTasksManagementForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxNIC = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxProjects = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonSearch = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonUpdate = new MaterialSkin.Controls.MaterialButton();
            this.materialMultiLineTextBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(26, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "NIC";
            // 
            // materialTextBoxNIC
            // 
            this.materialTextBoxNIC.AnimateReadOnly = false;
            this.materialTextBoxNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxNIC.Depth = 0;
            this.materialTextBoxNIC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxNIC.LeadingIcon = null;
            this.materialTextBoxNIC.Location = new System.Drawing.Point(93, 70);
            this.materialTextBoxNIC.MaxLength = 50;
            this.materialTextBoxNIC.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxNIC.Multiline = false;
            this.materialTextBoxNIC.Name = "materialTextBoxNIC";
            this.materialTextBoxNIC.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxNIC.TabIndex = 1;
            this.materialTextBoxNIC.Text = "";
            this.materialTextBoxNIC.TrailingIcon = null;
            this.materialTextBoxNIC.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(325, 77);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Projects";
            // 
            // materialComboBoxProjects
            // 
            this.materialComboBoxProjects.AutoResize = false;
            this.materialComboBoxProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxProjects.Depth = 0;
            this.materialComboBoxProjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxProjects.DropDownHeight = 118;
            this.materialComboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxProjects.DropDownWidth = 121;
            this.materialComboBoxProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxProjects.FormattingEnabled = true;
            this.materialComboBoxProjects.IntegralHeight = false;
            this.materialComboBoxProjects.ItemHeight = 29;
            this.materialComboBoxProjects.Location = new System.Drawing.Point(389, 71);
            this.materialComboBoxProjects.MaxDropDownItems = 4;
            this.materialComboBoxProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxProjects.Name = "materialComboBoxProjects";
            this.materialComboBoxProjects.Size = new System.Drawing.Size(214, 35);
            this.materialComboBoxProjects.StartIndex = 0;
            this.materialComboBoxProjects.TabIndex = 3;
            this.materialComboBoxProjects.UseTallSize = false;
            this.materialComboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxProjects_SelectedIndexChanged);
            // 
            // materialButtonSearch
            // 
            this.materialButtonSearch.AutoSize = false;
            this.materialButtonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearch.Depth = 0;
            this.materialButtonSearch.HighEmphasis = true;
            this.materialButtonSearch.Icon = null;
            this.materialButtonSearch.Location = new System.Drawing.Point(610, 70);
            this.materialButtonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearch.Name = "materialButtonSearch";
            this.materialButtonSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearch.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearch.TabIndex = 5;
            this.materialButtonSearch.Text = "Search";
            this.materialButtonSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearch.UseAccentColor = false;
            this.materialButtonSearch.UseVisualStyleBackColor = true;
            this.materialButtonSearch.Click += new System.EventHandler(this.materialButtonSearch_Click);
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.AnimateReadOnly = false;
            this.materialTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxName.LeadingIcon = null;
            this.materialTextBoxName.Location = new System.Drawing.Point(93, 113);
            this.materialTextBoxName.MaxLength = 50;
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Multiline = false;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxName.TabIndex = 6;
            this.materialTextBoxName.Text = "";
            this.materialTextBoxName.TrailingIcon = null;
            this.materialTextBoxName.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 120);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Name";
            // 
            // materialComboBoxStatus
            // 
            this.materialComboBoxStatus.AutoResize = false;
            this.materialComboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxStatus.Depth = 0;
            this.materialComboBoxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxStatus.DropDownHeight = 118;
            this.materialComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxStatus.DropDownWidth = 121;
            this.materialComboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxStatus.FormattingEnabled = true;
            this.materialComboBoxStatus.IntegralHeight = false;
            this.materialComboBoxStatus.ItemHeight = 29;
            this.materialComboBoxStatus.Location = new System.Drawing.Point(389, 112);
            this.materialComboBoxStatus.MaxDropDownItems = 4;
            this.materialComboBoxStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxStatus.Name = "materialComboBoxStatus";
            this.materialComboBoxStatus.Size = new System.Drawing.Size(214, 35);
            this.materialComboBoxStatus.StartIndex = 0;
            this.materialComboBoxStatus.TabIndex = 8;
            this.materialComboBoxStatus.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(325, 120);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Status";
            // 
            // materialButtonUpdate
            // 
            this.materialButtonUpdate.AutoSize = false;
            this.materialButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonUpdate.Depth = 0;
            this.materialButtonUpdate.HighEmphasis = true;
            this.materialButtonUpdate.Icon = null;
            this.materialButtonUpdate.Location = new System.Drawing.Point(610, 161);
            this.materialButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonUpdate.Name = "materialButtonUpdate";
            this.materialButtonUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonUpdate.Size = new System.Drawing.Size(78, 36);
            this.materialButtonUpdate.TabIndex = 10;
            this.materialButtonUpdate.Text = "Update";
            this.materialButtonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonUpdate.UseAccentColor = false;
            this.materialButtonUpdate.UseVisualStyleBackColor = true;
            this.materialButtonUpdate.Click += new System.EventHandler(this.materialButtonUpdate_Click);
            // 
            // materialMultiLineTextBoxDescription
            // 
            this.materialMultiLineTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBoxDescription.Depth = 0;
            this.materialMultiLineTextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBoxDescription.Location = new System.Drawing.Point(93, 155);
            this.materialMultiLineTextBoxDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBoxDescription.Name = "materialMultiLineTextBoxDescription";
            this.materialMultiLineTextBoxDescription.Size = new System.Drawing.Size(510, 96);
            this.materialMultiLineTextBoxDescription.TabIndex = 11;
            this.materialMultiLineTextBoxDescription.Text = "";
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.AutoSize = false;
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(610, 110);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(79, 36);
            this.materialButtonAdd.TabIndex = 12;
            this.materialButtonAdd.Text = "Add";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            this.materialButtonAdd.Click += new System.EventHandler(this.materialButtonAdd_Click);
            // 
            // materialButtonDelete
            // 
            this.materialButtonDelete.AutoSize = false;
            this.materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDelete.Depth = 0;
            this.materialButtonDelete.HighEmphasis = true;
            this.materialButtonDelete.Icon = null;
            this.materialButtonDelete.Location = new System.Drawing.Point(610, 209);
            this.materialButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete.Name = "materialButtonDelete";
            this.materialButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDelete.Size = new System.Drawing.Size(77, 36);
            this.materialButtonDelete.TabIndex = 13;
            this.materialButtonDelete.Text = "Delete";
            this.materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete.UseAccentColor = false;
            this.materialButtonDelete.UseVisualStyleBackColor = true;
            this.materialButtonDelete.Click += new System.EventHandler(this.materialButtonDelete_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(6, 193);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(81, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Description";
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderStatus});
            this.listViewTasks.Location = new System.Drawing.Point(6, 257);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(681, 252);
            this.listViewTasks.TabIndex = 15;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 0;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 500;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 100;
            // 
            // MemberProjectTasksManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 515);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialButtonDelete);
            this.Controls.Add(this.materialButtonAdd);
            this.Controls.Add(this.materialMultiLineTextBoxDescription);
            this.Controls.Add(this.materialButtonUpdate);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialComboBoxStatus);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBoxName);
            this.Controls.Add(this.materialButtonSearch);
            this.Controls.Add(this.materialComboBoxProjects);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialTextBoxNIC);
            this.Controls.Add(this.materialLabel1);
            this.Name = "MemberProjectTasksManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Project Tasks Management";
            this.Load += new System.EventHandler(this.MemberProjectTasksManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNIC;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxProjects;
        private MaterialSkin.Controls.MaterialButton materialButtonSearch;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBoxDescription;
        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private ListView listViewTasks;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderStatus;
    }
}