namespace ProjectsManagement.Forms
{
    partial class DashboardForm
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
            this.menuStripForManager = new System.Windows.Forms.MenuStrip();
            this.projectTypesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberProjectTasksManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectTasksManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripForManager.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripForManager
            // 
            this.menuStripForManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectTypesManagementToolStripMenuItem,
            this.membersManagementToolStripMenuItem,
            this.projectsManagementToolStripMenuItem,
            this.memberProjectTasksManagementToolStripMenuItem});
            this.menuStripForManager.Location = new System.Drawing.Point(0, 24);
            this.menuStripForManager.Name = "menuStripForManager";
            this.menuStripForManager.Size = new System.Drawing.Size(667, 24);
            this.menuStripForManager.TabIndex = 0;
            this.menuStripForManager.Text = "menuStrip1";
            // 
            // projectTypesManagementToolStripMenuItem
            // 
            this.projectTypesManagementToolStripMenuItem.Name = "projectTypesManagementToolStripMenuItem";
            this.projectTypesManagementToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.projectTypesManagementToolStripMenuItem.Text = "Project Types Management";
            // 
            // membersManagementToolStripMenuItem
            // 
            this.membersManagementToolStripMenuItem.Name = "membersManagementToolStripMenuItem";
            this.membersManagementToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.membersManagementToolStripMenuItem.Text = "Members Management";
            // 
            // projectsManagementToolStripMenuItem
            // 
            this.projectsManagementToolStripMenuItem.Name = "projectsManagementToolStripMenuItem";
            this.projectsManagementToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.projectsManagementToolStripMenuItem.Text = "Projects Management";
            // 
            // memberProjectTasksManagementToolStripMenuItem
            // 
            this.memberProjectTasksManagementToolStripMenuItem.Name = "memberProjectTasksManagementToolStripMenuItem";
            this.memberProjectTasksManagementToolStripMenuItem.Size = new System.Drawing.Size(208, 20);
            this.memberProjectTasksManagementToolStripMenuItem.Text = "Member Project Tasks Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectTasksManagementToolStripMenuItem1,
            this.profileManagementToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // projectTasksManagementToolStripMenuItem1
            // 
            this.projectTasksManagementToolStripMenuItem1.Name = "projectTasksManagementToolStripMenuItem1";
            this.projectTasksManagementToolStripMenuItem1.Size = new System.Drawing.Size(160, 20);
            this.projectTasksManagementToolStripMenuItem1.Text = "Project Tasks Management";
            // 
            // profileManagementToolStripMenuItem
            // 
            this.profileManagementToolStripMenuItem.Name = "profileManagementToolStripMenuItem";
            this.profileManagementToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.profileManagementToolStripMenuItem.Text = "Profile Management";
            this.profileManagementToolStripMenuItem.Click += new System.EventHandler(this.profileManagementToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.menuStripForManager);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripForManager;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.menuStripForManager.ResumeLayout(false);
            this.menuStripForManager.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripForManager;
        private ToolStripMenuItem projectTypesManagementToolStripMenuItem;
        private ToolStripMenuItem membersManagementToolStripMenuItem;
        private ToolStripMenuItem projectsManagementToolStripMenuItem;
        private ToolStripMenuItem memberProjectTasksManagementToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem projectTasksManagementToolStripMenuItem1;
        private ToolStripMenuItem profileManagementToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}