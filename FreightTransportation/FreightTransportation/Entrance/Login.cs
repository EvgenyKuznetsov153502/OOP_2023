using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreightTransportation
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Login() 
        {
            UserName= string.Empty;
            Password= string.Empty;
        }
        public Login(string username, string password)
        {
            UserName= username;
            Password= password;
        }

        public bool SignIn()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command= new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else 
                return false;

        }

        public bool IsCustomer()
        {
            string UserType = "customer";
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `user_type` = @uT", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = UserType;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
