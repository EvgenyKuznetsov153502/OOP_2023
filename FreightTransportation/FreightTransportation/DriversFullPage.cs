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
    public partial class DriversFullPage : Form
    {
        string UserName;
        public DriversFullPage(string userName)
        {
            InitializeComponent();
            UserName = userName;
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
            AdminMainPage admin = new AdminMainPage(UserName);
            admin.Show();
        }

        private new bool Load()
        {
            bool flag = true;
            try
            {
                BindingSource bindingSource = new BindingSource();
                Driver driver = new Driver();
                bindingSource.DataSource = driver.GetDrivers();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameField.Text;
            string telephone = TelephoneField.Text;
            bool IsEmpty = true;

            void CheckEmpty(System.Windows.Forms.TextBox field)
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

            bool Error = false;
            int FromStrToInt(System.Windows.Forms.TextBox textBox) // returns -1 if conversion failed
            {
                int result;
                try
                {
                    result = int.Parse(textBox.Text);
                    textBox.BackColor = Color.White;
                }
                catch
                {
                    result = -1;
                    Error = true;
                    textBox.BackColor = Color.IndianRed;
                }
                return result;
            }

            CheckEmpty(NameField);
            CheckEmpty(ExperienceField);
            CheckEmpty(TelephoneField);

            if (!IsEmpty)
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }

            int _experience = FromStrToInt(ExperienceField);

            if (Error)
            {
                MessageBox.Show("Incorrect data entered");
                return;
            }

            Driver driver = new Driver(name, _experience, telephone);

            if (driver.IsDriverExists())
            {
                NameField.BackColor = Color.IndianRed;
                MessageBox.Show("This name already exists, please enter another one");
                return;
            }
            else
            {
                NameField.BackColor = Color.White;
            }

            if (driver.AddDriver())
            {
                NameField.Text = string.Empty;
                ExperienceField.Text = string.Empty;
                TelephoneField.Text = string.Empty;
                
                if (!Load())
                {
                    MessageBox.Show("Error loading data");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error! Route not added");
            }



        }

        private void ExperienceField_KeyPress(object sender, KeyPressEventArgs e)
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
            if (DeleteBox.Text == string.Empty)
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
            Driver driver = new Driver();
            
            if (driver.IsIdExists(result))
            {
                DeleteBox.BackColor = Color.White;
            }
            else
            {
                DeleteBox.BackColor = Color.IndianRed;
                MessageBox.Show("Error! No such ID exists");
                return;
            }

            if (driver.Remove(result))
            {
                DeleteBox.Text = string.Empty;
                if (!Load())
                {
                    MessageBox.Show("Error loading data");
                }
            }
            else
            {
                MessageBox.Show("Error! Route not deleted");
            }
        }
    }
}
