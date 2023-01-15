using Microsoft.EntityFrameworkCore;
using ProjectsManagement.Entities;
using ProjectsManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectsManagement.Forms
{
    public partial class MembersManagementForm : Form
    {
        private Member selectedMember;

        public MembersManagementForm()
        {
            InitializeComponent();
        }

        private void FillListViewMembers()
        {
            listViewMembers.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (Member member in dbContext.Members.ToList())
            {
                ListViewItem listViewItem = new ListViewItem(member.Id.ToString());
                listViewItem.SubItems.Add(member.LastName);
                listViewItem.SubItems.Add(member.FirstName);
                listViewItem.SubItems.Add(member.NIC);
                listViewItem.SubItems.Add(member.PhoneNumber);
                listViewItem.SubItems.Add(member.Email);
                listViewItem.SubItems.Add((member.IsActive) ? "Yes" : "No");
                listViewMembers.Items.Add(listViewItem);
            }
        }

        private void FIllListViewMemberCompetencies(int memberId)
        {
            listViewMemberCompetencies.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (MemberCompetence memberCompetencie 
                in dbContext.MembersCompetencies.Include(mc => mc.Competence).Where(mc => mc.MemberId == memberId).ToList())
            {
                ListViewItem listViewItem = new ListViewItem(memberCompetencie.Id.ToString());
                listViewItem.SubItems.Add(memberCompetencie.Competence.Name);
                listViewMemberCompetencies.Items.Add(listViewItem);
            }
        }

        private void FillListViewCompetencies()
        {
            listViewCompetencies.Items.Clear();
            using AppDbContext dbContext = new AppDbContext();
            foreach (ProjectType projectType in dbContext.ProjectTypes.ToList())
            {
                ListViewItem listViewItem = new ListViewItem(projectType.Id.ToString());
                listViewItem.SubItems.Add(projectType.Name);
                listViewCompetencies.Items.Add(listViewItem);
            }
        }

        private void MembersManagementForm_Load(object sender, EventArgs e)
        {
            listViewMembers.FullRowSelect = true;
            listViewMembers.MultiSelect = false;
            listViewMemberCompetencies.FullRowSelect = true;
            listViewMemberCompetencies.MultiSelect = false;
            listViewCompetencies.FullRowSelect = true;
            listViewCompetencies.MultiSelect = false;
            FillListViewMembers();
            FillListViewCompetencies();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Length == 0 || textBoxFirstName.Text.Length == 0 || textBoxNIC.Text.Length == 0 
                || textBoxPhoneNumber.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.Members.Count(m => m.NIC == textBoxNIC.Text) > 0)
            {
                MessageBox.Show("NIC already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Members.Add(new Member
            {
                LastName = textBoxLastName.Text,
                FirstName = textBoxFirstName.Text,
                NIC = textBoxNIC.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Password = "123456",
                IsActive = true
            });
            dbContext.SaveChanges();
            MessageBox.Show("Member added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxNIC.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            listViewMemberCompetencies.Items.Clear();
            FillListViewMembers();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Length == 0 || textBoxFirstName.Text.Length == 0 || textBoxNIC.Text.Length == 0
                || textBoxPhoneNumber.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listViewMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            int memberId = int.Parse(listViewMembers.SelectedItems[0].SubItems[0].Text);
            if (dbContext.Members.Count(m => m.NIC == textBoxNIC.Text && m.Id != memberId) > 0)
            {
                MessageBox.Show("NIC already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedMember.LastName = textBoxLastName.Text;
            selectedMember.FirstName = textBoxFirstName.Text;
            selectedMember.NIC = textBoxNIC.Text;
            selectedMember.PhoneNumber = textBoxPhoneNumber.Text;
            selectedMember.Email = textBoxEmail.Text;
            dbContext.Members.Update(selectedMember);
            dbContext.SaveChanges();
            MessageBox.Show("Member updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxNIC.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            listViewMemberCompetencies.Items.Clear();
            FillListViewMembers();
        }

        private void listViewMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedIndices.Count > 0)
            {
                using AppDbContext dbContext = new AppDbContext();
                selectedMember = dbContext.Members.Find(int.Parse(listViewMembers.SelectedItems[0].SubItems[0].Text));
                textBoxLastName.Text = selectedMember.LastName;
                textBoxFirstName.Text = selectedMember.FirstName;
                textBoxNIC.Text = selectedMember.NIC;
                textBoxPhoneNumber.Text = selectedMember.PhoneNumber;
                textBoxEmail.Text = selectedMember.Email;
                buttonChnageIsActive.Text = (selectedMember.IsActive) ? "Deactivate" : "Activate";
                FIllListViewMemberCompetencies(selectedMember.Id);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            if (dbContext.MembersCompetencies.Count(mc => mc.MemberId == selectedMember.Id) > 0)
            {
                MessageBox.Show("You can't delete this member he has linked competencies!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.ProjectsMembers.Count(pm => pm.MemberId == selectedMember.Id) > 0)
            {
                MessageBox.Show("You can't delete this member he has linked projects!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.Tasks.Count(t => t.MemberId == selectedMember.Id) > 0)
            {
                MessageBox.Show("You can't delete this member he has linked tasks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.Members.Remove(selectedMember);
            dbContext.SaveChanges();
            MessageBox.Show("Member deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listViewMemberCompetencies.Items.Clear();
            FillListViewMembers();
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            selectedMember.Password = "123456";
            dbContext.Members.Update(selectedMember);
            dbContext.SaveChanges();
            MessageBox.Show("Member password has been reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonChnageIsActive_Click(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            selectedMember.IsActive = !selectedMember.IsActive;
            dbContext.Members.Update(selectedMember);
            dbContext.SaveChanges();
            MessageBox.Show($"Member has been {((selectedMember.IsActive) ? "activated" : "deactivated")}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listViewMemberCompetencies.Items.Clear();
            FillListViewMembers();
        }

        private void buttonAddCompetence_Click(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a member!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listViewCompetencies.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select a comptence!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            int competenceId = int.Parse(listViewCompetencies.SelectedItems[0].SubItems[0].Text);
            if (dbContext.MembersCompetencies.Count(mc => mc.MemberId == selectedMember.Id && mc.CompetenceId == competenceId) > 0)
            {
                MessageBox.Show("Member already has this comptence!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.MembersCompetencies.Add(new MemberCompetence{ MemberId = selectedMember.Id, CompetenceId = competenceId });
            dbContext.SaveChanges();
            MessageBox.Show("Competence added to member.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FIllListViewMemberCompetencies(selectedMember.Id);
        }

        private void buttonRemoveCompetence_Click(object sender, EventArgs e)
        {
            if (listViewMemberCompetencies.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select member comptence!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using AppDbContext dbContext = new AppDbContext();
            dbContext.Remove(new MemberCompetence { Id = int.Parse(listViewMemberCompetencies.SelectedItems[0].SubItems[0].Text) });
            dbContext.SaveChanges();
            MessageBox.Show("Member competence removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FIllListViewMemberCompetencies(selectedMember.Id);
        }
    }
}
