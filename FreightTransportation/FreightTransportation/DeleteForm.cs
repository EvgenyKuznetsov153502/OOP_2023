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
    public partial class DeleteForm : Form
    {
        string UserName;
        AccountForm Form;
        public DeleteForm(string userName, AccountForm form)
        {
            InitializeComponent();
            UserName = userName;
            Form= form;

        }

        private void NOButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.DeleteAccount(UserName))
            {
                this.Hide();
                Form.Hide();
                LoginForm1 loginForm1 = new LoginForm1();
                loginForm1.Show();
            }
            else
            {
                this.Hide();
                MessageBox.Show("Error! Account has not been deleted");
            }
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
    }
}
