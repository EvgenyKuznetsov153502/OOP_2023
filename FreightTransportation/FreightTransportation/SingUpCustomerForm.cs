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
    public partial class SingUpCustomerForm : Form
    {
        public SingUpCustomerForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 40);
            this.passRepField.AutoSize = false;
            this.passRepField.Size = new Size(this.passRepField.Width, 40);
        }

       
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void SignUpCustbutton_Click(object sender, EventArgs e)
        {
            String name = Full_Name.Text;
            String login = log.Text;
            String password = passField.Text;
            String repPassword = passRepField.Text;
            String mail = Mail.Text;
            String phone = tel.Text;
            bool IsEmpty = true;

            void CheckEmpty(TextBox field)
            {
                if(field.Text == string.Empty)
                {
                    IsEmpty = false;
                    field.BackColor = Color.IndianRed;
                }
                else
                {
                    field.BackColor = Color.White;
                }

            }
            CheckEmpty(Full_Name);
            CheckEmpty(log);
            CheckEmpty(passField);
            CheckEmpty(passRepField);
            CheckEmpty(Mail);
            CheckEmpty(tel);

            if (!IsEmpty)
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }
           

            if(password != repPassword)
            {
                passField.BackColor = Color.IndianRed;
                passRepField.BackColor = Color.IndianRed;
                passField.Text = string.Empty;
                passRepField.Text = string.Empty;
                MessageBox.Show("Passwords in the fields are different");
                return;
            }
            else
            {
                passField.BackColor = Color.White;
                passRepField.BackColor = Color.White;
            }

            Registration registration = new Registration(login, password, name, mail, phone);

            if (registration.IsUserExists())
            {
                log.BackColor = Color.IndianRed;
                MessageBox.Show("This login already exists, please enter another one");
                return;
            }
            else
            {
                log.BackColor= Color.White;
            }


            if (registration.SignUpAsCustomer())
            {
                Full_Name.Text = string.Empty;
                log.Text = string.Empty;
                passField.Text= string.Empty;
                passRepField.Text= string.Empty;
                Mail.Text = string.Empty;
                tel.Text = string.Empty;
                MessageBox.Show("Account created successfully");
            }
               

            else
                MessageBox.Show("Error! Account not created");


        }
    }
}
