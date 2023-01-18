using Microsoft.EntityFrameworkCore;
using ProjectsManagement.Entities;
using ProjectsManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectsManagement.Forms
{
    public partial class DashboardForm : Form
    {
        private Person person;
        private bool isAdmin;

        public DashboardForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            isAdmin = person is Manager;
            menuStripForManager.Visible = isAdmin;
            projectTypesManagementToolStripMenuItem.Visible = isAdmin;
            membersManagementToolStripMenuItem.Visible = isAdmin;
            projectsManagementToolStripMenuItem.Visible = isAdmin;
            memberProjectTasksManagementToolStripMenuItem.Visible = isAdmin;
            projectTasksManagementToolStripMenuItem1.Visible = !isAdmin;
        }

        private void FillProjectsStatuesChart()
        {
            chartProjects.Series.Clear();
            using AppDbContext dbContext = new AppDbContext();
            var statistics = dbContext.Tasks
                .GroupBy(t => new { ProjectName = t.Project.Name, ProjectType = t.Project.Type.Name })
                .Select(s => new
                {
                    ProjectFullName = $"{s.Key.ProjectName} / {s.Key.ProjectType}",
                    ToDoCount = s.Count(s => s.Status == ProgressStatuses.To_Do),
                    InProgressCount = s.Count(s => s.Status == ProgressStatuses.In_Progress),
                    DoneCount = s.Count(s => s.Status == ProgressStatuses.Done)
                }).ToList();
            foreach (var statistic in statistics)
            {
                Series series = chartProjects.Series.Add(statistic.ProjectFullName);
                Random random = new Random();
                Color randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                series.Color = randomColor;
                DataPoint dataPointTodo = series.Points.Add(statistic.ToDoCount);
                dataPointTodo.Label = "To Do";
                dataPointTodo.Color = randomColor;
                DataPoint dataPointInProgress = series.Points.Add(statistic.InProgressCount);
                dataPointInProgress.Label = "In Progress";
                dataPointInProgress.Color = randomColor;
                DataPoint dataPointDone = series.Points.Add(statistic.DoneCount);
                dataPointDone.Label = "Done";
                dataPointDone.Color = randomColor;
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            chartProjects.Visible = isAdmin;
            labelProjects.Visible = isAdmin;
            comboBoxProjects.Visible = isAdmin;
            chartProject.Visible = isAdmin;
            if (isAdmin)
            {
                FillProjectsStatuesChart();
                using AppDbContext dbContext = new AppDbContext();
                comboBoxProjects.DisplayMember = "NameAndType";
                comboBoxProjects.DataSource = dbContext.Projects.Include(p => p.Type).ToList();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(person).ShowDialog();
        }

        private void profileManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProfileInformationForm(person).ShowDialog();
        }

        private void projectTasksManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProjectTasksManagementForm((Member)person).ShowDialog();
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartProject.Series.Clear();
            using AppDbContext dbContext = new AppDbContext();
            var statistics = dbContext.Tasks
                .Where(t => t.ProjectId == ((Project)comboBoxProjects.SelectedItem).Id)
                .GroupBy(t => new { t.Member.Id, t.Member.LastName, t.Member.FirstName })
                .Select(s => new
                {
                    MemberFullName = $"{s.Key.LastName} {s.Key.FirstName}",
                    ToDoCount = s.Count(s => s.Status == ProgressStatuses.To_Do),
                    InProgressCount = s.Count(s => s.Status == ProgressStatuses.In_Progress),
                    DoneCount = s.Count(s => s.Status == ProgressStatuses.Done)
                }).ToList();
            foreach (var statistic in statistics)
            {
                Series series = chartProject.Series.Add(statistic.MemberFullName);
                Random random = new Random();
                Color randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                series.Color = randomColor;
                DataPoint dataPointTodo = series.Points.Add(statistic.ToDoCount);
                dataPointTodo.Label = "To Do";
                dataPointTodo.Color = randomColor;
                DataPoint dataPointInProgress = series.Points.Add(statistic.InProgressCount);
                dataPointInProgress.Label = "In Progress";
                dataPointInProgress.Color = randomColor;
                DataPoint dataPointDone = series.Points.Add(statistic.DoneCount);
                dataPointDone.Label = "Done";
                dataPointDone.Color = randomColor;
            }
        }

        private void chartProjectsStatues_DoubleClick(object sender, EventArgs e)
        {
            FillProjectsStatuesChart();
        }

        private void chartProjects_DoubleClick(object sender, EventArgs e)
        {
            comboBoxProjects_SelectedIndexChanged(sender, e);
        }

        private void projectTypesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProjectTypesManagementForm().ShowDialog();
        }

        private void membersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MembersManagementForm().ShowDialog();
        }

        private void projectsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProjectsManagementForm().ShowDialog();
        }

        private void memberProjectTasksManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberProjectTasksManagementForm().ShowDialog();
        }
    }
}
