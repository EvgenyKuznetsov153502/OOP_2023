using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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




    }
}
