using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FreightTransportation.WorkWithDB
{
    public  class Customer : User
    {
        string login, password, full_name, phone, email;
        public Customer() 
        {
            login = string.Empty;
            password = string.Empty;
            full_name = string.Empty;
            phone = string.Empty;
            email = string.Empty;
        }

        public Customer(string login): this()
        {
            this.login = login;
        }

        public Customer(string login, string password, string full_name, string phone, string email)
        {
            this.login = login;
            this.password = password;
            this.full_name = full_name;
            this.phone = phone;
            this.email = email;
        }

        public DataTable GetCustomers()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `user_type` = @uT", db.GetConnection());
            
            command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = "customer";

            adapter.SelectCommand = command;
            adapter.Fill(table);
            table.Columns.RemoveAt(2);
            table.Columns.RemoveAt(5);
            return table;
        }

        public DataTable SearchCustomer()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `user_type` = @uT", db.GetConnection());

            command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = "customer";
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            table.Columns.RemoveAt(2);
            table.Columns.RemoveAt(5);
            return table;
        }








    }
}
