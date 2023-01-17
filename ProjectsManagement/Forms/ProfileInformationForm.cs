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
    public partial class ProfileInformationForm : Form
    {
        private Person person;
        public ProfileInformationForm(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void ProfileInformationForm_Load(object sender, EventArgs e)
        {
            using AppDbContext dbContext = new AppDbContext();
            dbContext.Entry(person).Reload();
            textBoxLastName.Text = person.LastName;
            textBoxFirstName.Text = person.FirstName;
            textBoxEmail.Text = person.Email;
            textBoxNIC.Text = person.NIC;
            textBoxPhoneNumber.Text = person.PhoneNumber;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Length == 0 || textBoxFirstName.Text.Length == 0 || textBoxNIC.Text.Length == 0
                || textBoxPhoneNumber.Text.Length == 0 || textBoxEmail.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            if (dbContext.People.Count(p => p.NIC == textBoxNIC.Text && p.Id != person.Id) > 0)
            {
                MessageBox.Show("NIC already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.People.Count(p => p.Email == textBoxEmail.Text && p.Id != person.Id) > 0)
            {
                MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Entry(person).Reload();
            if (textBoxPassword.Text != person.Password)
            {
                MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            person.LastName = textBoxLastName.Text;
            person.FirstName = textBoxFirstName.Text;
            person.NIC = textBoxNIC.Text;
            person.Email = textBoxEmail.Text;
            person.PhoneNumber = textBoxPhoneNumber.Text;
            dbContext.People.Update(person);
            dbContext.SaveChanges();
            MessageBox.Show("Profile information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
