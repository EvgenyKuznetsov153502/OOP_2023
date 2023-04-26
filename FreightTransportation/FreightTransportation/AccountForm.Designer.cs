namespace FreightTransportation
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.MainPage = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Telephone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.titel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.MainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.titel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.MainPage.Controls.Add(this.DeleteButton);
            this.MainPage.Controls.Add(this.Telephone);
            this.MainPage.Controls.Add(this.email);
            this.MainPage.Controls.Add(this.FullName);
            this.MainPage.Controls.Add(this.pictureBox4);
            this.MainPage.Controls.Add(this.tel);
            this.MainPage.Controls.Add(this.Login);
            this.MainPage.Controls.Add(this.NameBox);
            this.MainPage.Controls.Add(this.Mail);
            this.MainPage.Controls.Add(this.BackButton);
            this.MainPage.Controls.Add(this.SaveButton);
            this.MainPage.Controls.Add(this.LoginBox);
            this.MainPage.Controls.Add(this.titel);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(1211, 751);
            this.MainPage.TabIndex = 2;
            this.MainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DeleteButton.Location = new System.Drawing.Point(868, 695);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Size = new System.Drawing.Size(175, 39);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete Account";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Telephone.Location = new System.Drawing.Point(86, 504);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(159, 38);
            this.Telephone.TabIndex = 21;
            this.Telephone.Text = "Telephone:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.email.Location = new System.Drawing.Point(147, 433);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(97, 38);
            this.email.TabIndex = 20;
            this.email.Text = "Email:";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FullName.Location = new System.Drawing.Point(86, 357);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(159, 38);
            this.FullName.TabIndex = 19;
            this.FullName.Text = "Full Name:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(800, 256);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(325, 268);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tel.Location = new System.Drawing.Point(263, 502);
            this.tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tel.MaxLength = 15;
            this.tel.Multiline = true;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(415, 50);
            this.tel.TabIndex = 18;
            this.tel.Text = "Telephone";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Location = new System.Drawing.Point(147, 278);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(98, 38);
            this.Login.TabIndex = 14;
            this.Login.Text = "Login:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameBox.Location = new System.Drawing.Point(263, 355);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.MaxLength = 40;
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(521, 50);
            this.NameBox.TabIndex = 13;
            this.NameBox.Text = "Name";
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.Mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mail.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mail.Location = new System.Drawing.Point(263, 431);
            this.Mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mail.MaxLength = 25;
            this.Mail.Multiline = true;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(415, 50);
            this.Mail.TabIndex = 12;
            this.Mail.Text = "Email";
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.BackButton.Location = new System.Drawing.Point(27, 695);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 39);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.SaveButton.Location = new System.Drawing.Point(1068, 695);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Size = new System.Drawing.Size(118, 39);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Enabled = false;
            this.LoginBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBox.Location = new System.Drawing.Point(263, 278);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBox.MaxLength = 18;
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(415, 50);
            this.LoginBox.TabIndex = 4;
            this.LoginBox.Text = "Login";
            // 
            // titel
            // 
            this.titel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.titel.Controls.Add(this.closeButton);
            this.titel.Controls.Add(this.WelcomeLabel);
            this.titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titel.Location = new System.Drawing.Point(0, 0);
            this.titel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(1211, 148);
            this.titel.TabIndex = 0;
            this.titel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titel_MouseDown);
            this.titel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titel_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Location = new System.Drawing.Point(1176, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Stencil", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(400, 41);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(452, 68);
            this.WelcomeLabel.TabIndex = 9;
            this.WelcomeLabel.Text = "Your Account";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 751);
            this.Controls.Add(this.MainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeAccountForm";
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.titel.ResumeLayout(false);
            this.titel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Panel titel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}