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
    public partial class MemberProjectTasksManagementForm : Form
    {
        private Member member;
        private Entities.Task selectedTask;

        public MemberProjectTasksManagementForm()
        {
            InitializeComponent();
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

        private void MemberProjectTasksManagementForm_Load(object sender, EventArgs e)
        {
            listViewTasks.FullRowSelect = true;
            listViewTasks.MultiSelect = false;
            comboBoxStatus.DataSource = new List<ProgressStatuses> { ProgressStatuses.To_Do, ProgressStatuses.In_Progress, ProgressStatuses.Done };
            comboBoxStatus.SelectedIndex = -1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxNIC.Text.Length == 0)
            {
                MessageBox.Show("NIC is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Text = "Member Project Tasks Management";
            comboBoxProjects.DataSource = null;
            textBoxName.Clear();
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            comboBoxStatus.Refresh();
            listViewTasks.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            member = dbContext.Members.FirstOrDefault(m => m.NIC == textBoxNIC.Text);
            if (member is null)
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Text = $"{member.FullName} Project Tasks Management";
            comboBoxProjects.DisplayMember = "NameAndType";
            comboBoxProjects.DataSource = dbContext.Projects.Include(p => p.Type)
                .Where(p => p.Members.Count(m => m.MemberId == member.Id) > 0).ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNIC.Text.Length == 0 || comboBoxProjects.SelectedIndex < 0 ||
                textBoxName.Text.Length == 0 || comboBoxStatus.SelectedIndex < 0 ||
                richTextBoxDescription.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Tasks.Count(t => t.Name == textBoxName.Text) > 0)
            {
                MessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Tasks.Add(new Entities.Task
            {
                Name = textBoxName.Text,
                Description = richTextBoxDescription.Text,
                Status = (ProgressStatuses)comboBoxStatus.SelectedItem,
                ProjectId = ((Project)comboBoxProjects.SelectedItem).Id,
                MemberId = member.Id
            });
            dbContext.SaveChanges();
            MessageBox.Show("Task added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            comboBoxStatus.Refresh();
            FillListViewTasks();
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProjects.SelectedIndex >= 0)
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
                textBoxName.Text = selectedTask.Name;
                richTextBoxDescription.Text = selectedTask.Description;
                comboBoxStatus.SelectedItem = selectedTask.Status;
                comboBoxStatus.Refresh();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxNIC.Text.Length == 0 || comboBoxProjects.SelectedIndex < 0 ||
                textBoxName.Text.Length == 0 || comboBoxStatus.SelectedIndex < 0 ||
                richTextBoxDescription.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Tasks.Count(t => t.Name == textBoxName.Text && t.Id != selectedTask.Id) > 0)
            {
                MessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedTask.Name = textBoxName.Text;
            selectedTask.Description = richTextBoxDescription.Text;
            selectedTask.Status = (ProgressStatuses)comboBoxStatus.SelectedItem;
            dbContext.Update(selectedTask);
            dbContext.SaveChanges();
            MessageBox.Show("Task updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            comboBoxStatus.Refresh();
            FillListViewTasks();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            dbContext.Remove(selectedTask);
            dbContext.SaveChanges();
            MessageBox.Show("Task deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            richTextBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = -1;
            comboBoxStatus.Refresh();
            FillListViewTasks();
        }
    }
}
