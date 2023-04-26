namespace FreightTransportation
{
    partial class EmployeeMainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainPage));
            this.MainPage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DriversBox = new System.Windows.Forms.ComboBox();
            this.DriversLabel = new System.Windows.Forms.Label();
            this.ProcessingLabel = new System.Windows.Forms.Label();
            this.ListOfRequestLabel = new System.Windows.Forms.Label();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdminButton = new System.Windows.Forms.Button();
            this.routesButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.SignUpCustbutton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserNameText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.MainPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.MainPage.Controls.Add(this.button1);
            this.MainPage.Controls.Add(this.panel1);
            this.MainPage.Controls.Add(this.ListOfRequestLabel);
            this.MainPage.Controls.Add(this.Loadbutton);
            this.MainPage.Controls.Add(this.dataGridView1);
            this.MainPage.Controls.Add(this.AdminButton);
            this.MainPage.Controls.Add(this.routesButton);
            this.MainPage.Controls.Add(this.customersButton);
            this.MainPage.Controls.Add(this.HistoryButton);
            this.MainPage.Controls.Add(this.PaymentButton);
            this.MainPage.Controls.Add(this.SignUpCustbutton);
            this.MainPage.Controls.Add(this.BackButton);
            this.MainPage.Controls.Add(this.panel2);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(1407, 795);
            this.MainPage.TabIndex = 1;
            this.MainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.button1.Location = new System.Drawing.Point(1249, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сompletion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.IdBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AcceptButton);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.DriversBox);
            this.panel1.Controls.Add(this.DriversLabel);
            this.panel1.Controls.Add(this.ProcessingLabel);
            this.panel1.Location = new System.Drawing.Point(37, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 356);
            this.panel1.TabIndex = 34;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(149, 94);
            this.IdBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdBox.MaxLength = 6;
            this.IdBox.Multiline = true;
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(253, 39);
            this.IdBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(75, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID:";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.AcceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.AcceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.AcceptButton.Location = new System.Drawing.Point(283, 294);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(119, 39);
            this.AcceptButton.TabIndex = 39;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.Font = new System.Drawing.Font("Cooper Black", 14.2F);
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(149, 228);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(253, 35);
            this.StatusBox.TabIndex = 38;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StatusLabel.Location = new System.Drawing.Point(24, 221);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(106, 38);
            this.StatusLabel.TabIndex = 37;
            this.StatusLabel.Text = "Status:";
            // 
            // DriversBox
            // 
            this.DriversBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriversBox.Font = new System.Drawing.Font("Cooper Black", 14.2F);
            this.DriversBox.FormattingEnabled = true;
            this.DriversBox.Location = new System.Drawing.Point(149, 158);
            this.DriversBox.Name = "DriversBox";
            this.DriversBox.Size = new System.Drawing.Size(253, 35);
            this.DriversBox.TabIndex = 36;
            // 
            // DriversLabel
            // 
            this.DriversLabel.AutoSize = true;
            this.DriversLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DriversLabel.Location = new System.Drawing.Point(24, 151);
            this.DriversLabel.Name = "DriversLabel";
            this.DriversLabel.Size = new System.Drawing.Size(107, 38);
            this.DriversLabel.TabIndex = 35;
            this.DriversLabel.Text = "Driver:";
            // 
            // ProcessingLabel
            // 
            this.ProcessingLabel.AutoSize = true;
            this.ProcessingLabel.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ProcessingLabel.Location = new System.Drawing.Point(118, 13);
            this.ProcessingLabel.Name = "ProcessingLabel";
            this.ProcessingLabel.Size = new System.Drawing.Size(195, 45);
            this.ProcessingLabel.TabIndex = 34;
            this.ProcessingLabel.Text = "Processing:";
            // 
            // ListOfRequestLabel
            // 
            this.ListOfRequestLabel.AutoSize = true;
            this.ListOfRequestLabel.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfRequestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ListOfRequestLabel.Location = new System.Drawing.Point(654, 158);
            this.ListOfRequestLabel.Name = "ListOfRequestLabel";
            this.ListOfRequestLabel.Size = new System.Drawing.Size(382, 45);
            this.ListOfRequestLabel.TabIndex = 33;
            this.ListOfRequestLabel.Text = "Requests in processing:";
            // 
            // Loadbutton
            // 
            this.Loadbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loadbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.Loadbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.Loadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loadbutton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.Loadbutton.Location = new System.Drawing.Point(1276, 745);
            this.Loadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loadbutton.Size = new System.Drawing.Size(119, 39);
            this.Loadbutton.TabIndex = 32;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 435);
            this.dataGridView1.TabIndex = 30;
            // 
            // AdminButton
            // 
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.AdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.AdminButton.Location = new System.Drawing.Point(1249, 167);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminButton.Size = new System.Drawing.Size(146, 39);
            this.AdminButton.TabIndex = 18;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // routesButton
            // 
            this.routesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.routesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.routesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.routesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routesButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.routesButton.Location = new System.Drawing.Point(1249, 231);
            this.routesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.routesButton.Name = "routesButton";
            this.routesButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.routesButton.Size = new System.Drawing.Size(146, 39);
            this.routesButton.TabIndex = 17;
            this.routesButton.Text = "Routes";
            this.routesButton.UseVisualStyleBackColor = true;
            this.routesButton.Click += new System.EventHandler(this.routesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.customersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.customersButton.Location = new System.Drawing.Point(1249, 294);
            this.customersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersButton.Name = "customersButton";
            this.customersButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersButton.Size = new System.Drawing.Size(146, 39);
            this.customersButton.TabIndex = 16;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.HistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.HistoryButton.Location = new System.Drawing.Point(1249, 416);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HistoryButton.Size = new System.Drawing.Size(146, 39);
            this.HistoryButton.TabIndex = 15;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.PaymentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.PaymentButton.Location = new System.Drawing.Point(1249, 477);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentButton.Size = new System.Drawing.Size(146, 40);
            this.PaymentButton.TabIndex = 14;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // SignUpCustbutton
            // 
            this.SignUpCustbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpCustbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.SignUpCustbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.SignUpCustbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpCustbutton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpCustbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.SignUpCustbutton.Location = new System.Drawing.Point(1249, 541);
            this.SignUpCustbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpCustbutton.Name = "SignUpCustbutton";
            this.SignUpCustbutton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpCustbutton.Size = new System.Drawing.Size(146, 39);
            this.SignUpCustbutton.TabIndex = 13;
            this.SignUpCustbutton.Text = "Account";
            this.SignUpCustbutton.UseVisualStyleBackColor = true;
            this.SignUpCustbutton.Click += new System.EventHandler(this.SignUpCustbutton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.BackButton.Location = new System.Drawing.Point(12, 745);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 39);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Exit";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.UserNameText);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.WelcomeLabel);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1407, 148);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // UserNameText
            // 
            this.UserNameText.AutoSize = true;
            this.UserNameText.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UserNameText.Location = new System.Drawing.Point(70, 95);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(102, 38);
            this.UserNameText.TabIndex = 17;
            this.UserNameText.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Stencil", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(385, 27);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(651, 68);
            this.WelcomeLabel.TabIndex = 10;
            this.WelcomeLabel.Text = "Employee home page";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Location = new System.Drawing.Point(1372, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // EmployeeMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 795);
            this.Controls.Add(this.MainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMainPage";
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UserNameText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button SignUpCustbutton;
        private System.Windows.Forms.Button routesButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Label ListOfRequestLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProcessingLabel;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.ComboBox DriversBox;
        private System.Windows.Forms.Label DriversLabel;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button button1;
    }
}