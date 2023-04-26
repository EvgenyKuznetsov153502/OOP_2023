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
using System.Xml.Linq;

namespace FreightTransportation
{
    public partial class CustomerListForm : Form
    {
        string UserName;
        public CustomerListForm(string userName)
        {
            InitializeComponent();
            UserName = userName;
            UserNameText.Text = userName;
            dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
           
            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseMove(object sender, MouseEventArgs e)
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
            EmployeeMainPage employeeMainPage = new EmployeeMainPage(UserName);
            employeeMainPage.Show();
        }

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Customer customer = new Customer();
                
                bindingSource.DataSource = customer.GetCustomers();
                
                dataGridView1.DataSource = bindingSource;

            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        private void routesButton_Click(object sender, EventArgs e)
        {
            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string Login = SearchField.Text;

            if (Login == string.Empty)
            {
                SearchField.BackColor = Color.IndianRed;
                MessageBox.Show("Fill in the field");
                return;
            }
            else
            {
                SearchField.BackColor = Color.White;
            }
            try
            {
                BindingSource bindingSource = new BindingSource();
                Customer customer = new Customer(Login);

                bindingSource.DataSource = customer.SearchCustomer();

                dataGridView1.DataSource = bindingSource;

            }
            catch
            {
                MessageBox.Show("Error loading data");
            }


        }
    }
}
