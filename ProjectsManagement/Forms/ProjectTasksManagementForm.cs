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

namespace ProjectsManagement.Forms
{
    public partial class ProjectTasksManagementForm : Form
    {
        private Member member;
        private Entities.Task selectedTask;

        public ProjectTasksManagementForm(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void FillListViewTasks()
        {
            listViewTasks.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (Entities.Task task in dbContext.Tasks
                .Where(t => t.MemberId == member.Id && t.ProjectId == ((Project)comboBoxProjects.SelectedItem).Id)
                .ToList())
            {
                ListViewItem listViewItem = new ListViewItem(task.Id.ToString());
                listViewItem.SubItems.Add(task.Name);
                listViewItem.SubItems.Add(task.Status.ToString());
                listViewTasks.Items.Add(listViewItem);
            }
        }

        private void ProjectTasksManagementForm_Load(object sender, EventArgs e)
        {
            listViewTasks.MultiSelect = false;
            listViewTasks.FullRowSelect = true;
            comboBoxStatus.DataSource = new List<ProgressStatuses> { ProgressStatuses.To_Do, ProgressStatuses.In_Progress, ProgressStatuses.Done };
            comboBoxStatus.SelectedIndex = -1;
            using AppDbContext dbContext = new AppDbContext();
            comboBoxProjects.DisplayMember = "NameAndType";
            comboBoxProjects.DataSource = dbContext.Projects.Include(p => p.Type).Where(p => p.Members.Count(m => m.MemberId == member.Id) > 0).ToList();
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProjects.SelectedIndex > -1)
            {
                FillListViewTasks();
            }
        }

        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                using AppDbContext dbContext = new AppDbContext();
                selectedTask = dbContext.Tasks.Find(int.Parse(listViewTasks.SelectedItems[0].SubItems[0].Text));
                comboBoxStatus.SelectedItem = selectedTask.Status;
                richTextBoxDescription.Text = selectedTask.Description;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (richTextBoxDescription.Text.Length == 0 || comboBoxProjects.SelectedIndex < 0 || comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            selectedTask.Description = richTextBoxDescription.Text;
            selectedTask.Status = (ProgressStatuses)comboBoxStatus.SelectedItem;
            dbContext.Update(selectedTask);
            dbContext.SaveChanges();
            MessageBox.Show("Task updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            FillListViewTasks();
        }
    }
}
