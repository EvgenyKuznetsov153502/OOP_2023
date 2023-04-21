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
    public partial class CustomerHistory : Form
    {
        string UserName;
        public CustomerHistory(string name)
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
            CustomerMainPage customerMainPage = new CustomerMainPage(UserName);
            customerMainPage.Show();
        }

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Request request = new Request();
                bindingSource.DataSource = request.GetCustRequests();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(DeleteBox.Text == string.Empty)
            {
                DeleteBox.BackColor = Color.IndianRed;
                MessageBox.Show("Fill in the field");
                return;
            }
            else
            {
                DeleteBox.BackColor = Color.White;
            }

            int result;
            try
            {
                result = int.Parse(DeleteBox.Text);
                DeleteBox.BackColor = Color.White;
            }
            catch
            {
                result = -1;
                DeleteBox.BackColor = Color.IndianRed;
                MessageBox.Show("Incorrect data entered");
                return;
            }

            Request request = new Request();

            if (request.IsIdExists(result))
            {
                DeleteBox.BackColor = Color.White;
            }
            else
            {
                DeleteBox.BackColor = Color.IndianRed;
                MessageBox.Show("Error! No such ID exists");
                return;
            }

            if (request.Remove(result))
            {
                DeleteBox.Text = string.Empty;
                if (!Load())
                {
                    MessageBox.Show("Error loading data");
                }
            }
            else
            {
                MessageBox.Show("Error! Driver not deleted");
            }

        }
    }
}
