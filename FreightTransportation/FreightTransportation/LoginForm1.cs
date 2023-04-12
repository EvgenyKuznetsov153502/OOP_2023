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
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 40);

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
            if(e.Button == MouseButtons.Left)
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
        private void NameOfProgrem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }


        }

        private void NameOfProgrem_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passwordUser = passField.Text;
            Login login = new Login(loginUser, passwordUser);

            if (login.SignIn())
            {
                
                loginField.BackColor = Color.White;
                passField.BackColor = Color.White;
                if (login.IsCustomer())
                {
                    this.Hide();
                    CustomerMainPage customerMainPage = new CustomerMainPage(loginUser);
                    customerMainPage.Show();
                }
                else
                {
                    this.Hide();
                    EmployeeMainPage employeeMainPage = new EmployeeMainPage(loginUser);
                    employeeMainPage.Show();
                }   
            }
            else
            {
                loginField.BackColor = Color.IndianRed;
                passField.BackColor = Color.IndianRed;
                MessageBox.Show("Incorrect login or password");
            }
               

        }

        private void SignUpAsСustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingUpCustomerForm customerForm = new SingUpCustomerForm();
            customerForm.Show();

        }

        private void SignUpAsEmplButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpEmployeeForm employeeForm = new SignUpEmployeeForm();
            employeeForm.Show();
        }
    }
}
