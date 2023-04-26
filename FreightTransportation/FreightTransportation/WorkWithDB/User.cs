using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FreightTransportation.WorkWithDB
{
    public  class User
    {
        protected int id;
        public User() { id = -1; }
        public User(int id) { this.id = id;}
       
        public int GetId() { return id; }
        public void SetId(int id) { this.id = id;}

        public DataTable GetAllUsers()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool IsIdExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }


        public bool Remove()
        {
            bool IsRemoved = false;
            
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsRemoved = true;

            db.CloseConnection();

            return IsRemoved;
        }

        public DataRow GetUser(string login)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @log", db.GetConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            return row;
        }

        public string GetFullName(string login)
        {
            DataRow row = GetUser(login);
            string name = row["full_name"].ToString();
            return name;
        }

        public string GetTelephone(string login)
        {
            DataRow row = GetUser(login);
            string phone = row["telephone"].ToString();
            return phone;
        }

        public string GetEmail(string login)
        {
            DataRow row = GetUser(login);
            string email = row["email"].ToString();
            return email;
        }


        public bool ChangeData(string login, string name, string phone, string mail)
        {

            bool flag = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `full_name` = @name," +
                " `telephone` = @phone, `email` = @mail WHERE `login` = @log", db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;
        }

        public bool DeleteAccount(string login) 
        {
            bool flag = false;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `login` = @log", db.GetConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;
        }
    }
}
