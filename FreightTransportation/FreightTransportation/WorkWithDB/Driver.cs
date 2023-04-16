using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FreightTransportation.WorkWithDB
{
    public class Driver
    {
        int experience, payment;
        string name, telephone, OnRoute;

        public Driver() 
        {
            
            experience = 0;
            payment = 0;
            name= string.Empty;
            telephone = string.Empty;
            OnRoute = "No";
        }

        public Driver(string name, int experience, string telephone, int payment = 0, string OnRoute = "No")
        {   
            this.experience = experience;
            this.payment = payment;
            this.name = name;
            this.telephone = telephone;
            this.OnRoute = OnRoute;
        }

        public DataTable GetDrivers()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `drivers`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool IsDriverExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `drivers` WHERE `name` = @dN", db.GetConnection());
            command.Parameters.Add("@dN", MySqlDbType.VarChar).Value = name;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }


        public bool AddDriver()
        {
            bool IsAdded = false;
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `drivers` (`name`, `experience`, `telephone`, `payment`, `OnRoute`) VALUES (@name, @exp, @phone, @pay, @onRoute)", db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@exp", MySqlDbType.Int32).Value = experience;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = telephone;
            command.Parameters.Add("@pay", MySqlDbType.Int32).Value = payment;
            command.Parameters.Add("@onRoute", MySqlDbType.VarChar).Value = OnRoute;


            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsAdded = true;

            db.CloseConnection();

            return IsAdded;
        }


        public bool Remove(int _ID)
        {
            bool IsRemoved = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `drivers` WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = _ID;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsRemoved = true;

            db.CloseConnection();

            return IsRemoved;
        }


        public bool IsIdExists(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `drivers` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
