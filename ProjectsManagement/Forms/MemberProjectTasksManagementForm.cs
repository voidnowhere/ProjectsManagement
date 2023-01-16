using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class MemberProjectTasksManagementForm : MaterialForm
    {
        private Member member;
        private Entities.Task selectedTask;

        public MemberProjectTasksManagementForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue900, Accent.LightBlue700, TextShade.WHITE);
        }

        private void FillListViewTasks()
        {
            listViewTasks.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (Entities.Task task in dbContext.Tasks
                .Where(t => t.MemberId == member.Id && t.ProjectId == ((Project)materialComboBoxProjects.SelectedItem).Id)
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
            materialComboBoxStatus.DataSource = new List<ProgressStatuses> { ProgressStatuses.To_Do, ProgressStatuses.In_Progress, ProgressStatuses.Done };
            materialComboBoxStatus.SelectedIndex = -1;
        }

        private void materialButtonSearch_Click(object sender, EventArgs e)
        {
            if (materialTextBoxNIC.Text.Length == 0)
            {
                MessageBox.Show("NIC is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Text = "Member Project Tasks Management";
            materialComboBoxProjects.DataSource = null;
            materialTextBoxName.Clear();
            materialMultiLineTextBoxDescription.Clear();
            materialComboBoxStatus.SelectedIndex = -1;
            materialComboBoxStatus.Refresh();
            listViewTasks.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            member = dbContext.Members.FirstOrDefault(m => m.NIC == materialTextBoxNIC.Text);
            if (member is null)
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Text = $"{member.FullName} Project Tasks Management";
            materialComboBoxProjects.DisplayMember = "NameAndType";
            materialComboBoxProjects.DataSource = dbContext.Projects.Include(p => p.Type)
                .Where(p => p.Members.Count(m => m.MemberId == member.Id) > 0).ToList();
        }

        private void materialButtonAdd_Click(object sender, EventArgs e)
        {
            if (materialTextBoxNIC.Text.Length == 0 || materialComboBoxProjects.SelectedIndex < 0 ||
                materialTextBoxName.Text.Length == 0 || materialComboBoxStatus.SelectedIndex < 0 ||
                materialMultiLineTextBoxDescription.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Tasks.Count(t => t.Name == materialTextBoxName.Text) > 0)
            {
                MessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Tasks.Add(new Entities.Task
            {
                Name = materialTextBoxName.Text,
                Description = materialMultiLineTextBoxDescription.Text,
                Status = (ProgressStatuses)materialComboBoxStatus.SelectedItem,
                ProjectId = ((Project)materialComboBoxProjects.SelectedItem).Id,
                MemberId = member.Id
            });
            dbContext.SaveChanges();
            MessageBox.Show("Task added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            materialTextBoxName.Clear();
            materialMultiLineTextBoxDescription.Clear();
            materialComboBoxStatus.SelectedIndex = -1;
            materialComboBoxStatus.Refresh();
            FillListViewTasks();
        }

        private void materialComboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialComboBoxProjects.SelectedIndex >= 0)
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
                materialTextBoxName.Text = selectedTask.Name;
                materialMultiLineTextBoxDescription.Text = selectedTask.Description;
                materialComboBoxStatus.SelectedItem = selectedTask.Status;
                materialComboBoxStatus.Refresh();
            }
        }

        private void materialButtonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (materialTextBoxNIC.Text.Length == 0 || materialComboBoxProjects.SelectedIndex < 0 ||
                materialTextBoxName.Text.Length == 0 || materialComboBoxStatus.SelectedIndex < 0 ||
                materialMultiLineTextBoxDescription.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Tasks.Count(t => t.Name == materialTextBoxName.Text && t.Id != selectedTask.Id) > 0)
            {
                MessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedTask.Name = materialTextBoxName.Text;
            selectedTask.Description = materialMultiLineTextBoxDescription.Text;
            selectedTask.Status = (ProgressStatuses)materialComboBoxStatus.SelectedItem;
            dbContext.Update(selectedTask);
            dbContext.SaveChanges();
            MessageBox.Show("Task updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            materialTextBoxName.Clear();
            materialMultiLineTextBoxDescription.Clear();
            materialComboBoxStatus.SelectedIndex = -1;
            materialComboBoxStatus.Refresh();
            FillListViewTasks();
        }

        private void materialButtonDelete_Click(object sender, EventArgs e)
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
            materialTextBoxName.Clear();
            materialMultiLineTextBoxDescription.Clear();
            materialComboBoxStatus.SelectedIndex = -1;
            materialComboBoxStatus.Refresh();
            FillListViewTasks();
        }
    }
}
