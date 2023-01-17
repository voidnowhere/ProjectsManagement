using ProjectsManagement.Entities;
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
    }
}
