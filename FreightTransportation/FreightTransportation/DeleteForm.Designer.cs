namespace FreightTransportation
{
    partial class DeleteForm
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
            this.MainPage = new System.Windows.Forms.Panel();
            this.YesButton = new System.Windows.Forms.Button();
            this.QuestuinLavel = new System.Windows.Forms.Label();
            this.NOButton = new System.Windows.Forms.Button();
            this.MainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(4)))), ((int)(((byte)(22)))));
            this.MainPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPage.Controls.Add(this.YesButton);
            this.MainPage.Controls.Add(this.QuestuinLavel);
            this.MainPage.Controls.Add(this.NOButton);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(494, 292);
            this.MainPage.TabIndex = 3;
            this.MainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            // 
            // YesButton
            // 
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.YesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.YesButton.Location = new System.Drawing.Point(257, 178);
            this.YesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YesButton.Name = "YesButton";
            this.YesButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YesButton.Size = new System.Drawing.Size(118, 39);
            this.YesButton.TabIndex = 22;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // QuestuinLavel
            // 
            this.QuestuinLavel.AutoSize = true;
            this.QuestuinLavel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestuinLavel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuestuinLavel.Location = new System.Drawing.Point(90, 68);
            this.QuestuinLavel.Name = "QuestuinLavel";
            this.QuestuinLavel.Size = new System.Drawing.Size(309, 76);
            this.QuestuinLavel.TabIndex = 14;
            this.QuestuinLavel.Text = "Do you really want to \r\ndelete your account ?";
            // 
            // NOButton
            // 
            this.NOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NOButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.NOButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.NOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NOButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(139)))));
            this.NOButton.Location = new System.Drawing.Point(97, 178);
            this.NOButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NOButton.Name = "NOButton";
            this.NOButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NOButton.Size = new System.Drawing.Size(118, 39);
            this.NOButton.TabIndex = 5;
            this.NOButton.Text = "No";
            this.NOButton.UseVisualStyleBackColor = true;
            this.NOButton.Click += new System.EventHandler(this.NOButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 292);
            this.Controls.Add(this.MainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label QuestuinLavel;
        private System.Windows.Forms.Button NOButton;
    }
}