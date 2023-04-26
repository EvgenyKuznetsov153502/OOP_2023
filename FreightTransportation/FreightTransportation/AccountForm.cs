using System;
using FreightTransportation.WorkWithDB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FreightTransportation
{
    public partial class AccountForm : Form
    {
        string UserName;
        public AccountForm(string userName)
        {
            InitializeComponent();
            UserName = userName;
            LoginBox.Text = userName;
            User user = new User();
            NameBox.Text = user.GetFullName(userName);
            Mail.Text = user.GetEmail(userName);
            tel.Text = user.GetTelephone(userName);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;


            }
        }

        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint2;

        private void titel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }

        private void titel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.SetLogin(UserName);
            this.Hide();
            if (log.IsCustomer())
            {
                CustomerMainPage customerMainPage = new CustomerMainPage(UserName);
                customerMainPage.Show();
            }
            else
            {
                EmployeeMainPage employeeMainPage = new EmployeeMainPage(UserName);
                employeeMainPage.Show();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string full_name = NameBox.Text;
            string email = Mail.Text;
            string telephone = tel.Text;

            bool IsEmpty = true;

            void CheckEmpty(TextBox field)
            {
                if (field.Text == string.Empty)
                {
                    IsEmpty = false;
                    field.BackColor = Color.IndianRed;
                }
                else
                {
                    field.BackColor = Color.FromArgb(18,4,22);
                }
            }

            CheckEmpty(NameBox);
            CheckEmpty(Mail);
            CheckEmpty(tel);

            if (!IsEmpty)
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }
            User user = new User();
            if (user.ChangeData(UserName, full_name, telephone, email))
            {
                MessageBox.Show("Data saved successfully");
            }
            else
            {
                NameBox.Text = user.GetFullName(UserName);
                Mail.Text = user.GetEmail(UserName);
                tel.Text = user.GetTelephone(UserName);
                MessageBox.Show("Error! The data was not saved");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(UserName,this);
            deleteForm.ShowDialog();
        }
    }
}
