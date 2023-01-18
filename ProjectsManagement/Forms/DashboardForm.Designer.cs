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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
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
            this.chartProjects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.labelProjects = new System.Windows.Forms.Label();
            this.menuStripForManager.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProject)).BeginInit();
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
            this.menuStripForManager.Size = new System.Drawing.Size(880, 24);
            this.menuStripForManager.TabIndex = 0;
            this.menuStripForManager.Text = "menuStrip1";
            // 
            // projectTypesManagementToolStripMenuItem
            // 
            this.projectTypesManagementToolStripMenuItem.Name = "projectTypesManagementToolStripMenuItem";
            this.projectTypesManagementToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.projectTypesManagementToolStripMenuItem.Text = "Project Types Management";
            this.projectTypesManagementToolStripMenuItem.Click += new System.EventHandler(this.projectTypesManagementToolStripMenuItem_Click);
            // 
            // membersManagementToolStripMenuItem
            // 
            this.membersManagementToolStripMenuItem.Name = "membersManagementToolStripMenuItem";
            this.membersManagementToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.membersManagementToolStripMenuItem.Text = "Members Management";
            this.membersManagementToolStripMenuItem.Click += new System.EventHandler(this.membersManagementToolStripMenuItem_Click);
            // 
            // projectsManagementToolStripMenuItem
            // 
            this.projectsManagementToolStripMenuItem.Name = "projectsManagementToolStripMenuItem";
            this.projectsManagementToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.projectsManagementToolStripMenuItem.Text = "Projects Management";
            this.projectsManagementToolStripMenuItem.Click += new System.EventHandler(this.projectsManagementToolStripMenuItem_Click);
            // 
            // memberProjectTasksManagementToolStripMenuItem
            // 
            this.memberProjectTasksManagementToolStripMenuItem.Name = "memberProjectTasksManagementToolStripMenuItem";
            this.memberProjectTasksManagementToolStripMenuItem.Size = new System.Drawing.Size(208, 20);
            this.memberProjectTasksManagementToolStripMenuItem.Text = "Member Project Tasks Management";
            this.memberProjectTasksManagementToolStripMenuItem.Click += new System.EventHandler(this.memberProjectTasksManagementToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // projectTasksManagementToolStripMenuItem1
            // 
            this.projectTasksManagementToolStripMenuItem1.Name = "projectTasksManagementToolStripMenuItem1";
            this.projectTasksManagementToolStripMenuItem1.Size = new System.Drawing.Size(160, 20);
            this.projectTasksManagementToolStripMenuItem1.Text = "Project Tasks Management";
            this.projectTasksManagementToolStripMenuItem1.Click += new System.EventHandler(this.projectTasksManagementToolStripMenuItem1_Click);
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
            // chartProjects
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProjects.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProjects.Legends.Add(legend1);
            this.chartProjects.Location = new System.Drawing.Point(12, 51);
            this.chartProjects.Name = "chartProjects";
            this.chartProjects.Size = new System.Drawing.Size(856, 250);
            this.chartProjects.TabIndex = 2;
            this.chartProjects.Text = "Projects Chart";
            this.chartProjects.DoubleClick += new System.EventHandler(this.chartProjectsStatues_DoubleClick);
            // 
            // chartProject
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProject.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProject.Legends.Add(legend2);
            this.chartProject.Location = new System.Drawing.Point(12, 336);
            this.chartProject.Name = "chartProject";
            this.chartProject.Size = new System.Drawing.Size(856, 250);
            this.chartProject.TabIndex = 3;
            this.chartProject.Text = "chart1";
            this.chartProject.DoubleClick += new System.EventHandler(this.chartProjects_DoubleClick);
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(494, 307);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(374, 23);
            this.comboBoxProjects.TabIndex = 4;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.Location = new System.Drawing.Point(439, 310);
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(49, 15);
            this.labelProjects.TabIndex = 5;
            this.labelProjects.Text = "Projects";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 594);
            this.Controls.Add(this.labelProjects);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.chartProject);
            this.Controls.Add(this.chartProjects);
            this.Controls.Add(this.menuStripForManager);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripForManager;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStripForManager.ResumeLayout(false);
            this.menuStripForManager.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProject)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProjects;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProject;
        private ComboBox comboBoxProjects;
        private Label labelProjects;
    }
}