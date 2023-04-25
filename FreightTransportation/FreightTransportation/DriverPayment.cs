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
    public partial class DriverPayment : Form
    {
        string UserName;
        public DriverPayment(string userName)
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
            EmployeeMainPage employeeMainPage = new EmployeeMainPage(UserName);
            employeeMainPage.Show();
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

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Driver driver = new Driver();
                bindingSource.DataSource = driver.GetDriversToPayment();
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            string id = IDBox.Text;
            if (id == string.Empty)
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

            
            Driver driver = new Driver();

            if (driver.IsIdExists(result))
            {
                IDBox.BackColor = Color.White;
            }
            else
            {
                IDBox.BackColor = Color.IndianRed;
                MessageBox.Show("Error! No such ID exists");
                return;
            }

            if (driver.PaymentToZero(result))
            {
                IDBox.BackColor = Color.White;
                IDBox.Text = string.Empty;
                if (!Load())
                {
                    MessageBox.Show("Error loading data");
                }
                MessageBox.Show("The payment was made successfully");
                return;
            }
        }
    }
}
