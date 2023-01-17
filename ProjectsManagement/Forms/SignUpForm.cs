using Azure.Identity;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void materialButtonSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Length == 0 || textBoxFirstName.Text.Length == 0 || textBoxNIC.Text.Length == 0
                || textBoxPhoneNumber.Text.Length == 0 || textBoxEmail.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            if (dbContext.People.Count(p => p.NIC == textBoxNIC.Text) > 0)
            {
                MessageBox.Show("NIC already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.People.Count(p => p.Email == textBoxEmail.Text) > 0)
            {
                MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Members.Add(new Member
            {
                LastName = textBoxLastName.Text,
                FirstName = textBoxFirstName.Text,
                NIC = textBoxNIC.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text,
                IsActive = false
            });
            dbContext.SaveChanges();
            MessageBox.Show("Account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
