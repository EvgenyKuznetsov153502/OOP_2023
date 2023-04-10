namespace FreightTransportation
{
    partial class CustomerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainPage));
            this.titel = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameText = new System.Windows.Forms.Label();
            this.SignUpCustbutton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.Panel();
            this.titel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.titel.Controls.Add(this.UserNameText);
            this.titel.Controls.Add(this.pictureBox1);
            this.titel.Controls.Add(this.closeButton);
            this.titel.Controls.Add(this.WelcomeLabel);
            this.titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titel.Location = new System.Drawing.Point(0, 0);
            this.titel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(1215, 148);
            this.titel.TabIndex = 0;
            this.titel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titel_MouseDown);
            this.titel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titel_MouseMove);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Stencil", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(281, 32);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(663, 68);
            this.WelcomeLabel.TabIndex = 9;
            this.WelcomeLabel.Text = "Customer home page";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Location = new System.Drawing.Point(1180, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameText
            // 
            this.UserNameText.AutoSize = true;
            this.UserNameText.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UserNameText.Location = new System.Drawing.Point(63, 100);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(102, 38);
            this.UserNameText.TabIndex = 15;
            this.UserNameText.Text = "LOGIN";
            // 
            // SignUpCustbutton
            // 
            this.SignUpCustbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpCustbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.SignUpCustbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.SignUpCustbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpCustbutton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpCustbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.SignUpCustbutton.Location = new System.Drawing.Point(21, 574);
            this.SignUpCustbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpCustbutton.Name = "SignUpCustbutton";
            this.SignUpCustbutton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpCustbutton.Size = new System.Drawing.Size(124, 39);
            this.SignUpCustbutton.TabIndex = 5;
            this.SignUpCustbutton.Text = "Account";
            this.SignUpCustbutton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.BackButton.Location = new System.Drawing.Point(21, 700);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 39);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Exit";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.button1.Location = new System.Drawing.Point(21, 636);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.MainPage.Controls.Add(this.button1);
            this.MainPage.Controls.Add(this.BackButton);
            this.MainPage.Controls.Add(this.SignUpCustbutton);
            this.MainPage.Controls.Add(this.titel);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(1215, 757);
            this.MainPage.TabIndex = 2;
            this.MainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            // 
            // CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 757);
            this.Controls.Add(this.MainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainPage";
            this.titel.ResumeLayout(false);
            this.titel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titel;
        private System.Windows.Forms.Label UserNameText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button SignUpCustbutton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MainPage;
    }
}