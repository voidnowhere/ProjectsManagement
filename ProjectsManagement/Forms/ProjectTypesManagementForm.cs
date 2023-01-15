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
    public partial class ProjectTypesManagementForm : Form
    {
        private ProjectType selectedProjectType;

        public ProjectTypesManagementForm()
        {
            InitializeComponent();
        }

        private void FillListViewListViewProjectTypes()
        {
            listViewProjectTypes.Items.Clear();
            foreach (ProjectType type in new AppDbContext().ProjectTypes.ToList())
            {
                ListViewItem listViewItem = new ListViewItem(type.Id.ToString());
                listViewItem.SubItems.Add(type.Name);
                listViewProjectTypes.Items.Add(listViewItem);
            }
        }

        private void ProjectTypesManagementForm_Load(object sender, EventArgs e)
        {
            listViewProjectTypes.MultiSelect = false;
            listViewProjectTypes.FullRowSelect = true;
            FillListViewListViewProjectTypes();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            dbContext.ProjectTypes.Add(new ProjectType { Name = textBoxName.Text });
            dbContext.SaveChanges();
            MessageBox.Show("Project type added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            FillListViewListViewProjectTypes();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewProjectTypes.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            selectedProjectType.Name = textBoxName.Text;
            dbContext.ProjectTypes.Update(selectedProjectType);
            dbContext.SaveChanges();
            MessageBox.Show("Project type updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            FillListViewListViewProjectTypes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewProjectTypes.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a project type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Projects.Count(p => p.TypeId == selectedProjectType.Id) > 0)
            {
                MessageBox.Show("You can't delete this project type he has linked projects!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.MembersCompetencies.Count(mc => mc.CompetenceId == selectedProjectType.Id) > 0)
            {
                MessageBox.Show("You can't delete this project type he has linked members!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.ProjectTypes.Remove(selectedProjectType);
            dbContext.SaveChanges();
            MessageBox.Show("Project type deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            FillListViewListViewProjectTypes();
        }

        private void listViewProjectTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProjectTypes.SelectedIndices.Count > 0)
            {
                using AppDbContext dbContext = new AppDbContext();
                selectedProjectType = dbContext.ProjectTypes.Find(int.Parse(listViewProjectTypes.SelectedItems[0].SubItems[0].Text));
                textBoxName.Text = selectedProjectType.Name;
            }
        }
    }
}
