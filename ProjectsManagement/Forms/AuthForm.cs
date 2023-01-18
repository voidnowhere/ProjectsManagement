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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxNIC.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            Person? person = dbContext.People.FirstOrDefault(p => p.NIC == textBoxNIC.Text && p.Password == textBoxPassword.Text);
            textBoxPassword.Clear();
            if (person is null)
            {
                MessageBox.Show("Verify your NIC or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (person is Member && !((Member)person).IsActive)
            {
                MessageBox.Show("Contact administrator for further information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxNIC.Clear();
            Hide();
            new DashboardForm(person).ShowDialog();
            Show();
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            new SignUpForm().ShowDialog();
            Show();
        }
    }
}
