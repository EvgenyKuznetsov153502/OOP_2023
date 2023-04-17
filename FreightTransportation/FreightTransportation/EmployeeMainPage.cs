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
    public partial class EmployeeMainPage : Form
    {
        private string UserName;
        public EmployeeMainPage(string name)
        {
            InitializeComponent();
            UserName= name;
            UserNameText.Text= name;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red; ;
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
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 log_form = new LoginForm1();
            log_form.Show();
        }

        private void routesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoutesForm routesForm = new RoutesForm(UserName);
            routesForm.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin(UserName);
            adminLogin.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerListForm customerListForm = new CustomerListForm(UserName);
            customerListForm.Show();
        }
    }
}
