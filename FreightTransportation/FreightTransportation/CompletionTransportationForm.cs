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

namespace FreightTransportation
{
    public partial class CompletionTransportationForm : Form
    {
        string Username;
        public CompletionTransportationForm(string username)
        {
            InitializeComponent();
            Username = username;
            UserNameText.Text = Username;
            Award.Text = "0";
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
            this.Hide(); ;
            EmployeeMainPage mainPage = new EmployeeMainPage(Username);
            mainPage.Show();
        }

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Request request = new Request();
                bindingSource.DataSource = request.GetApprovedRequests();
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

        private void СompleteButton_Click(object sender, EventArgs e)
        {
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
                    field.BackColor = Color.White;
                }

            }
            CheckEmpty(IDBox);
            CheckEmpty(Award);
            
            if (!IsEmpty)
            {
                MessageBox.Show("Fill in all the fields");
                return;
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

            int AwardSum;
            try
            {
                AwardSum = int.Parse(Award.Text);
                Award.BackColor = Color.White;
            }
            catch
            {
                AwardSum = -1;
                Award.BackColor = Color.IndianRed;
                MessageBox.Show("Incorrect data entered");
                return;
            }


            Request request = new Request();

            if (request.IsIdExists_Approved(result))
            {
                IDBox.BackColor = Color.White;
            }
            else
            {
                IDBox.BackColor = Color.IndianRed;
                MessageBox.Show("Error! No such ID exists");
                return;
            }

            string route;
            int payment;
            string driverName;

            try
            {
                route = request.GetRoute(result);
                payment = new Route().GetPayment(route);
                AwardSum += payment;
                driverName = request.GetDriver(result);
                //MessageBox.Show(AwardSum.ToString());
                //MessageBox.Show(driver.ToString());

            }
            catch
            {
                MessageBox.Show("Error! Request not processed.");
                return;
            }

            Driver driver = new Driver(driverName);

            if (!driver.Payment(AwardSum))
            {
                MessageBox.Show("Error! Request not processed.");
                return;
            }

            if (!request.ChangeStatusToComplete(result))
            {
                MessageBox.Show("Error! Request not processed.");
                return;
            }

            IDBox.Text = string.Empty;
            Award.Text = "0";

            if (!Load())
            {
                MessageBox.Show("Error loading data");
            }

            MessageBox.Show("Transportation completed successfully");
        }

        

        private void Award_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
