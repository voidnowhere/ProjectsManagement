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
using System.Windows.Forms.VisualStyles;

namespace ProjectsManagement.Forms
{
    public partial class ProjectsManagementForm : Form
    {
        private Project selectedProject;

        public ProjectsManagementForm()
        {
            InitializeComponent();
        }

        private void FillListViewProjects()
        {
            listViewProjects.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (Project project in dbContext.Projects.Include(p => p.Type).ToList())
            {
                ListViewItem listViewItem = new ListViewItem(project.Id.ToString());
                listViewItem.SubItems.Add(project.Name);
                listViewItem.SubItems.Add(project.Status.ToString().Replace("_", " "));
                listViewItem.SubItems.Add(project.Type.Name);
                listViewItem.SubItems.Add((project.IsActive) ? "Yes" : "No");
                listViewProjects.Items.Add(listViewItem);
            }
        }

        private void FillListViewQualifiedMembers()
        {
            listViewQualifiedMembers.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (Member member 
                in dbContext.Members.Where(m => m.Competencies.Count(c => c.CompetenceId == selectedProject.TypeId) > 0 
                    && m.Projects.Count(p => p.ProjectId == selectedProject.Id) == 0).ToList())
            {
                ListViewItem listViewItem = new ListViewItem(member.Id.ToString());
                listViewItem.SubItems.Add($"{member.NIC} {member.FullName}");
                listViewQualifiedMembers.Items.Add(listViewItem);
            }
        }

        private void FillListViewProjectMembers()
        {
            listViewProjectMembers.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (ProjectMember projectMember
                in dbContext.ProjectsMembers.Include(pm => pm.Member).Where(pm => pm.ProjectId == selectedProject.Id).ToList())
            {
                ListViewItem listViewItem = new ListViewItem(projectMember.Id.ToString());
                listViewItem.SubItems.Add($"{projectMember.Member.NIC} {projectMember.Member.FullName}");
                listViewProjectMembers.Items.Add(listViewItem);
            }
        }

        private void FillComboBoxProjectType()
        {
            comboBoxProjectType.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            comboBoxProjectType.DataSource = dbContext.ProjectTypes.ToList();
        }

        private ProgressStatuses GetSelectedStatus()
        {
            switch (comboBoxStatus.SelectedIndex)
            {
                case 0: return ProgressStatuses.To_Do;
                case 1: return ProgressStatuses.In_Progress;
                case 2: return ProgressStatuses.Done;
            }
            return ProgressStatuses.To_Do;
        }

        private void ProjectsManagementForm_Load(object sender, EventArgs e)
        {
            listViewProjects.FullRowSelect = true;
            listViewProjects.MultiSelect = false;
            listViewProjectMembers.FullRowSelect = true;
            listViewProjectMembers.MultiSelect = false;
            listViewQualifiedMembers.FullRowSelect = true;
            listViewQualifiedMembers.MultiSelect = false;
            comboBoxProjectType.DisplayMember = "Name";
            comboBoxStatus.DataSource = new List<ProgressStatuses> { ProgressStatuses.To_Do, ProgressStatuses.In_Progress, ProgressStatuses.Done };
            FillComboBoxProjectType();
            FillListViewProjects();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || comboBoxProjectType.SelectedIndex < 0 || richTextBoxDescription.Text.Length == 0
                || comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Projects.Count(p => p.Name == textBoxName.Text) > 0)
            {
                MessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Projects.Add(new Project
            {
                Name = textBoxName.Text,
                TypeId = ((ProjectType)comboBoxProjectType.SelectedItem).Id,
                Description = richTextBoxDescription.Text,
                Status = GetSelectedStatus(),
                IsActive = true,
            });
            dbContext.SaveChanges();
            MessageBox.Show("Project added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            comboBoxProjectType.SelectedIndex = -1;
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            listViewProjectMembers.Items.Clear();
            listViewQualifiedMembers.Items.Clear();
            FillListViewProjects();
        }

        private void listViewProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedIndices.Count > 0)
            {
                using AppDbContext dbContext = new AppDbContext();
                selectedProject = dbContext.Projects
                    .Include(p => p.Type)
                    .First(p => p.Id == int.Parse(listViewProjects.SelectedItems[0].SubItems[0].Text));
                textBoxName.Text = selectedProject.Name;
                comboBoxProjectType.Text = selectedProject.Type.Name;
                richTextBoxDescription.Text = selectedProject.Description;
                comboBoxStatus.Text = selectedProject.Status.ToString();
                buttonChangeIsActive.Text = (selectedProject.IsActive) ? "Deactivate" : "Activate";
                FillListViewProjectMembers();
                FillListViewQualifiedMembers();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxName.Text.Length == 0 || comboBoxProjectType.SelectedIndex < 0 || richTextBoxDescription.Text.Length == 0
                || comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Projects.Count(p => p.Name == textBoxName.Text && p.Id != selectedProject.Id) > 0)
            {
                MessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedProject.Name = textBoxName.Text;
            selectedProject.Type = (ProjectType)comboBoxProjectType.SelectedItem;
            selectedProject.Description = richTextBoxDescription.Text;
            selectedProject.Status = (ProgressStatuses)comboBoxStatus.SelectedItem;
            dbContext.Projects.Update(selectedProject);
            dbContext.SaveChanges();
            MessageBox.Show("Project updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            comboBoxProjectType.SelectedIndex = -1;
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            listViewProjectMembers.Items.Clear();
            listViewQualifiedMembers.Items.Clear();
            FillListViewProjects();
        }

        private void buttonChangeIsActive_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            selectedProject.IsActive = !selectedProject.IsActive;
            dbContext.Projects.Update(selectedProject);
            dbContext.SaveChanges();
            MessageBox.Show($"Project has been {((selectedProject.IsActive) ? "activated" : "deactivated")}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            comboBoxProjectType.SelectedIndex = -1;
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            listViewProjectMembers.Items.Clear();
            listViewQualifiedMembers.Items.Clear();
            FillListViewProjects();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.ProjectsMembers.Count(pm => pm.ProjectId == selectedProject.Id) > 0)
            {
                MessageBox.Show("You can't delete this project it has linked members!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.Tasks.Count(t => t.ProjectId == selectedProject.Id) > 0)
            {
                MessageBox.Show("You can't delete this project it has linked tasks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Projects.Remove(new Project { Id = selectedProject.Id });
            dbContext.SaveChanges();
            MessageBox.Show("Project deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            comboBoxProjectType.SelectedIndex = -1;
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            listViewProjectMembers.Items.Clear();
            listViewQualifiedMembers.Items.Clear();
            FillListViewProjects();
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listViewQualifiedMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a qualified member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            int memberId = int.Parse(listViewQualifiedMembers.SelectedItems[0].SubItems[0].Text);
            if (dbContext.ProjectsMembers.Count(pm => pm.ProjectId == selectedProject.Id && pm.MemberId == memberId) > 0)
            {
                MessageBox.Show("Member already affected to this project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.ProjectsMembers.Add(new ProjectMember { ProjectId = selectedProject.Id, MemberId = memberId });
            dbContext.SaveChanges();
            MessageBox.Show("Member added to project.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillListViewProjectMembers();
            FillListViewQualifiedMembers();
        }

        private void buttonRemoveMember_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listViewProjectMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            dbContext.ProjectsMembers.Remove(new ProjectMember { Id = int.Parse(listViewProjectMembers.SelectedItems[0].SubItems[0].Text) });
            dbContext.SaveChanges();
            MessageBox.Show("Member removed from project.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillListViewProjectMembers();
            FillListViewQualifiedMembers();
        }
    }
}
