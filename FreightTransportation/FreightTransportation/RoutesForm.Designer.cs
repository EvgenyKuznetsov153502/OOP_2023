namespace FreightTransportation
{
    partial class RoutesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutesForm));
            this.MainPage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PaymentField = new System.Windows.Forms.TextBox();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.DistanceField = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AddRouteLable = new System.Windows.Forms.Label();
            this.RoutNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.Panel();
            this.UserNameText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.PanelForDeleting = new System.Windows.Forms.Panel();
            this.DeleteLabal = new System.Windows.Forms.Label();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MainPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.titel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelForDeleting.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.MainPage.Controls.Add(this.PanelForDeleting);
            this.MainPage.Controls.Add(this.panel1);
            this.MainPage.Controls.Add(this.dataGridView1);
            this.MainPage.Controls.Add(this.BackButton);
            this.MainPage.Controls.Add(this.Loadbutton);
            this.MainPage.Controls.Add(this.titel);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(1251, 784);
            this.MainPage.TabIndex = 3;
            this.MainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.PriceField);
            this.panel1.Controls.Add(this.PriceLabel);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.PaymentField);
            this.panel1.Controls.Add(this.PaymentLabel);
            this.panel1.Controls.Add(this.DistanceField);
            this.panel1.Controls.Add(this.DistanceLabel);
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.AddRouteLable);
            this.panel1.Controls.Add(this.RoutNameLabel);
            this.panel1.Location = new System.Drawing.Point(24, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 387);
            this.panel1.TabIndex = 14;
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceField.Location = new System.Drawing.Point(115, 271);
            this.PriceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceField.MaxLength = 6;
            this.PriceField.Multiline = true;
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(268, 39);
            this.PriceField.TabIndex = 22;
            this.PriceField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceField_KeyPress);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PriceLabel.Location = new System.Drawing.Point(36, 271);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(73, 31);
            this.PriceLabel.TabIndex = 21;
            this.PriceLabel.Text = "Price:";
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.AddButton.Location = new System.Drawing.Point(288, 331);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Size = new System.Drawing.Size(95, 39);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PaymentField
            // 
            this.PaymentField.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentField.Location = new System.Drawing.Point(115, 206);
            this.PaymentField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentField.MaxLength = 6;
            this.PaymentField.Multiline = true;
            this.PaymentField.Name = "PaymentField";
            this.PaymentField.Size = new System.Drawing.Size(268, 39);
            this.PaymentField.TabIndex = 20;
            this.PaymentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentField_KeyPress);
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PaymentLabel.Location = new System.Drawing.Point(-3, 209);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(113, 31);
            this.PaymentLabel.TabIndex = 19;
            this.PaymentLabel.Text = "Payment:";
            // 
            // DistanceField
            // 
            this.DistanceField.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceField.Location = new System.Drawing.Point(115, 146);
            this.DistanceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DistanceField.MaxLength = 5;
            this.DistanceField.Multiline = true;
            this.DistanceField.Name = "DistanceField";
            this.DistanceField.Size = new System.Drawing.Size(268, 39);
            this.DistanceField.TabIndex = 18;
            this.DistanceField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DistanceField_KeyPress);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DistanceLabel.Location = new System.Drawing.Point(-3, 149);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(112, 31);
            this.DistanceLabel.TabIndex = 17;
            this.DistanceLabel.Text = "Distance:";
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.Location = new System.Drawing.Point(115, 85);
            this.NameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameField.MaxLength = 30;
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(268, 39);
            this.NameField.TabIndex = 16;
            // 
            // AddRouteLable
            // 
            this.AddRouteLable.AutoSize = true;
            this.AddRouteLable.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRouteLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddRouteLable.Location = new System.Drawing.Point(119, 20);
            this.AddRouteLable.Name = "AddRouteLable";
            this.AddRouteLable.Size = new System.Drawing.Size(153, 41);
            this.AddRouteLable.TabIndex = 15;
            this.AddRouteLable.Text = "Add rout:";
            // 
            // RoutNameLabel
            // 
            this.RoutNameLabel.AutoSize = true;
            this.RoutNameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RoutNameLabel.Location = new System.Drawing.Point(28, 85);
            this.RoutNameLabel.Name = "RoutNameLabel";
            this.RoutNameLabel.Size = new System.Drawing.Size(83, 31);
            this.RoutNameLabel.TabIndex = 15;
            this.RoutNameLabel.Text = "Name:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 460);
            this.dataGridView1.TabIndex = 13;
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.BackButton.Location = new System.Drawing.Point(12, 734);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 39);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Loadbutton
            // 
            this.Loadbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loadbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.Loadbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.Loadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loadbutton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.Loadbutton.Location = new System.Drawing.Point(1115, 734);
            this.Loadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loadbutton.Size = new System.Drawing.Size(124, 39);
            this.Loadbutton.TabIndex = 5;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
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
            this.titel.Size = new System.Drawing.Size(1251, 148);
            this.titel.TabIndex = 0;
            this.titel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titel_MouseDown);
            this.titel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titel_MouseMove);
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
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Location = new System.Drawing.Point(1216, 0);
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
            this.WelcomeLabel.Location = new System.Drawing.Point(497, 41);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(249, 68);
            this.WelcomeLabel.TabIndex = 9;
            this.WelcomeLabel.Text = "Routes";
            // 
            // PanelForDeleting
            // 
            this.PanelForDeleting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.PanelForDeleting.Controls.Add(this.DeleteButton);
            this.PanelForDeleting.Controls.Add(this.DeleteBox);
            this.PanelForDeleting.Controls.Add(this.DeleteLabal);
            this.PanelForDeleting.Controls.Add(this.IDlabel);
            this.PanelForDeleting.Location = new System.Drawing.Point(414, 652);
            this.PanelForDeleting.Name = "PanelForDeleting";
            this.PanelForDeleting.Size = new System.Drawing.Size(416, 108);
            this.PanelForDeleting.TabIndex = 15;
            // 
            // DeleteLabal
            // 
            this.DeleteLabal.AutoSize = true;
            this.DeleteLabal.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLabal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DeleteLabal.Location = new System.Drawing.Point(88, 0);
            this.DeleteLabal.Name = "DeleteLabal";
            this.DeleteLabal.Size = new System.Drawing.Size(201, 41);
            this.DeleteLabal.TabIndex = 16;
            this.DeleteLabal.Text = "Delete route:";
            // 
            // DeleteBox
            // 
            this.DeleteBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBox.Location = new System.Drawing.Point(101, 56);
            this.DeleteBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBox.MaxLength = 6;
            this.DeleteBox.Multiline = true;
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(165, 39);
            this.DeleteBox.TabIndex = 21;
            this.DeleteBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteBox_KeyPress);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IDlabel.Location = new System.Drawing.Point(51, 59);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(44, 31);
            this.IDlabel.TabIndex = 22;
            this.IDlabel.Text = "ID:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.DeleteButton.Location = new System.Drawing.Point(293, 56);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Size = new System.Drawing.Size(102, 39);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 784);
            this.Controls.Add(this.MainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoutesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoutesForm";
            this.MainPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.titel.ResumeLayout(false);
            this.titel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelForDeleting.ResumeLayout(false);
            this.PanelForDeleting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Panel titel;
        private System.Windows.Forms.Label UserNameText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoutNameLabel;
        private System.Windows.Forms.Label AddRouteLable;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PaymentField;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.TextBox DistanceField;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Panel PanelForDeleting;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.Label DeleteLabal;
        private System.Windows.Forms.Label IDlabel;
    }
}