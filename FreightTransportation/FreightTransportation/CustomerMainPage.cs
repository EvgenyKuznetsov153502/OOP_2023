using FreightTransportation.WorkWithDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreightTransportation
{
    public partial class CustomerMainPage : Form
    {
        private string UserName;

        public CustomerMainPage(string name)
        {
            InitializeComponent();
            UserName = name;
            UserNameText.Text = name;
            dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }
            dateTimeLoad.MinDate = DateTime.Now;
            dateTimeUnload.MinDate = DateTime.Now;
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
            this.Hide();
            LoginForm1 loginForm = new LoginForm1();
            loginForm.Show();
        }

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Route route = new Route();
                bindingSource.DataSource = route.GetRoutesForCust();
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }
        }

        private void DeleteBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && e.KeyChar <= '9')
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string id = IDBox.Text;
            DateTime date_load = dateTimeLoad.Value.Date;
            DateTime date_unload = dateTimeUnload.Value.Date;
            if(id == string.Empty)
            {
                IDBox.BackColor = Color.IndianRed;
                MessageBox.Show("Fill in the field");
                return;
            }
            else
            {
                IDBox.BackColor = Color.White;
            }

            int result;
            try
            {
               result = int.Parse(IDBox.Text);
               IDBox.BackColor = Color.White;
            }
            catch
            {
                result = -1;
                IDBox.BackColor = Color.IndianRed;
                MessageBox.Show("Incorrect data entered");
                return;
            }

            Route route = new Route();

            if (route.IsIdExists(result))
            {
                IDBox.BackColor = Color.White;
            }
            else
            {
                IDBox.BackColor = Color.IndianRed;
                MessageBox.Show("Error! No such ID exists");
                return;
            }

            int compare = date_unload.CompareTo(date_load);
            if (compare < 0)
            {
                MessageBox.Show("The unloading date can't be earlier than the loading date");
                return;
            }

            string route_name = route.GetRouteName(result);
            string load = date_load.ToShortDateString();
            string unload = date_unload.ToShortDateString();

            Request request = new Request(route_name, load, unload, UserName, "in processing");

            if (request.IsRequestExists())
            {
                MessageBox.Show("Such a request already exists");
                return;
            }

            if (request.SendRequest())
            {
                IDBox.Text = string.Empty;
                dateTimeLoad.Value = dateTimeLoad.MinDate;
                dateTimeUnload.Value = dateTimeUnload.MinDate;
                MessageBox.Show("The request has been sent successfully");
            }
            else
            {
                MessageBox.Show("Error! Request not sented");
            }
        }
    }
}
