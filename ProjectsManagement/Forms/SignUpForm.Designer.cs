namespace ProjectsManagement.Forms
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label1 = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            textBoxNIC = new TextBox();
            label3 = new Label();
            textBoxPhoneNumber = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxPassword = new TextBox();
            label6 = new Label();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 13;
            label1.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(131, 25);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 14;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(131, 54);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 57);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 15;
            label2.Text = "First Name";
            // 
            // textBoxNIC
            // 
            textBoxNIC.Location = new Point(131, 83);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(100, 23);
            textBoxNIC.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 86);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 17;
            label3.Text = "NIC";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(131, 112);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(100, 23);
            textBoxPhoneNumber.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 115);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 19;
            label4.Text = "Phone Number";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(131, 141);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 144);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(131, 170);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 173);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 23;
            label6.Text = "Password";
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(90, 223);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(75, 23);
            buttonSignUp.TabIndex = 25;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += materialButtonSignUp_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 271);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(label4);
            Controls.Add(textBoxNIC);
            Controls.Add(label3);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(textBoxLastName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxNIC;
        private Label label3;
        private TextBox textBoxPhoneNumber;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label5;
        private TextBox textBoxPassword;
        private Label label6;
        private Button buttonSignUp;
    }
}