using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FreightTransportation
{
    public class Registration
    {
        string Login;
        string Password;
        string FullName;
        string Email;
        string Telephone;

        public Registration() 
        {
            Login= string.Empty;
            Password= string.Empty;
            FullName= string.Empty;
            Telephone= string.Empty;
            Email= string.Empty;
        }

        public Registration(string login, string password, string fullName, string email, string telephone)
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Email = email;
            Telephone = telephone;
        }

        
        public bool SignUpAsCustomer()
        {
            return SignUp("customer");
        }

        public bool IsUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool SignUpAsEmployee()
        {
            return SignUp("employee");
        }

        private bool SignUp(string UserType)
        {
            bool IsCreated = false;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `full_name`, `telephone`, `email`, `user_type`) VALUES (@login, @pass, @name, @tel, @em, @usType)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = FullName;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telephone;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@usType", MySqlDbType.VarChar).Value = UserType;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1) // returns true if the account was created
                IsCreated = true;

            db.CloseConnection();

            return IsCreated;

        }





    }
}
