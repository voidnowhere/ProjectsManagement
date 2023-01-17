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
    public partial class ChangePasswordForm : Form
    {
        Person person;
        public ChangePasswordForm(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0 || textBoxNew.Text.Length == 0 || textBoxConfirm.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxConfirm.Text != textBoxNew.Text)
            {
                MessageBox.Show("Confirm doesn't match new password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            dbContext.Entry(person).Reload();
            if (person.Password != textBoxPassword.Text)
            {
                MessageBox.Show("Verify your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            person.Password = textBoxConfirm.Text;
            dbContext.People.Update(person);
            dbContext.SaveChanges();
            MessageBox.Show("Password updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
