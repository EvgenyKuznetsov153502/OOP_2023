using FreightTransportation.WorkWithDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreightTransportation
{
    public partial class AdminLogin : Form
    {
        string UserName;
        public AdminLogin(string userName)
        {
            InitializeComponent();
            UserName = userName;
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
        private void AdminLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;


            }
        }

        private void AdminLogin_MouseDown(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeMainPage employeeMainPage = new EmployeeMainPage(UserName);
            employeeMainPage.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string password = passField.Text;
            if(password == string.Empty)
            {
                passField.BackColor= Color.IndianRed;
                MessageBox.Show("Fill in the field");
                return;
            }
            else
            {
                passField.BackColor = Color.White;
            }

            UniqueCode uniqueCode= new UniqueCode();

            if(uniqueCode.GetAdminCode() == password)
            {
                this.Hide();
                AdminMainPage adminMainPage = new AdminMainPage(UserName);
                adminMainPage.Show();
            }
            else
            {
                passField.BackColor = Color.IndianRed;
                MessageBox.Show("Error! Wrong password.");
                return;
            }
        }

        


    }
}
