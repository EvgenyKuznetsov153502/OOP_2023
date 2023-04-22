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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FreightTransportation
{
    public partial class EmployeeMainPage : Form
    {
        List<string> strings = new List<string>();
        private string UserName;
        public EmployeeMainPage(string name)
        {
            InitializeComponent();
            UserName= name;
            UserNameText.Text= name;
            dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }

            if (!LoadBoxs())
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

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Request request = new Request();
                bindingSource.DataSource = request.GetEmplRequests();
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        private bool LoadBoxs()
        {
            bool flag = true;
            try
            {
                DriversBox.DataSource = new Driver().GetFreeDrivers();
                DriversBox.DisplayMember = "name";
                strings.Add("approved");
                strings.Add("rejected");
                StatusBox.DataSource = strings;
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

            if (!LoadBoxs())
            {
                MessageBox.Show("Error loading data");
            }
        }

        


        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(IdBox.Text == string.Empty)
            {
                IdBox.BackColor = Color.IndianRed;
                MessageBox.Show("Fill in the field");
                return;
            }
            else
            {
                IdBox.BackColor = Color.White;
            }

            int result;
            try
            {
                result = int.Parse(IdBox.Text);
                IdBox.BackColor = Color.White;
            }
            catch
            {
                result = -1;
                IdBox.BackColor = Color.IndianRed;
                MessageBox.Show("Incorrect data entered");
                return;
            }

            Request request = new Request();

            if (request.IsIdExists_InProcessing(result))
            {
                IdBox.BackColor = Color.White;
            }
            else
            {
                IdBox.BackColor = Color.IndianRed;
                MessageBox.Show("Error! No such ID exists");
                return;
            }

            if(StatusBox.Text == "approved")
            {
                if(DriversBox.Text == string.Empty)
                {
                    MessageBox.Show("There are no available drivers");
                    return;
                }
                string driverName = DriversBox.Text;
                request.SetDriver(driverName);
                if(!request.Processing("approved", result))
                {
                    MessageBox.Show("Error! Request not processed.");
                    return;
                }
                Driver driver = new Driver(driverName);
                if (!driver.SendingOnTheRoad())
                {
                    MessageBox.Show("Error! Request not processed.");
                    return;
                }
            }
            else
            {
                request.SetDriver(string.Empty);
                if(request.Processing("rejected", result))
                {
                    MessageBox.Show("Error! Request not processed.");
                    return;
                }
            }
            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }

            if (!LoadBoxs())
            {
                MessageBox.Show("Error loading data");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompletionTransportationForm form = new CompletionTransportationForm(UserName);
            form.Show();
        }
    }
}
