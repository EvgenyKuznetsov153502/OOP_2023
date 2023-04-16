using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace FreightTransportation.WorkWithDB
{
    public class Route
    {
        int Distance, Payment, Price;
        string Name;

        public Route() 
        {
            Distance= 0;
            Payment= 0;
            Price= 0;
            Name = string.Empty;
        }

        public Route(string _name, int _distance, int _payment, int _price)
        {
            Name= _name;
            Distance= _distance;
            Payment= _payment;
            Price = _price;
        }

        public DataTable GetRoutes()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `routes`", db.GetConnection());

            adapter.SelectCommand= command;
            adapter.Fill(table);

            return table;
        }

        public bool IsRouteExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `routes` WHERE `name` = @rN", db.GetConnection());
            command.Parameters.Add("@rN", MySqlDbType.VarChar).Value = Name;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool AddRoute()
        {
            bool IsAdded = false;
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `routes` (`name`, `distance`, `payment`, `price`) VALUES (@name, @dis, @pay, @price)", db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@dis", MySqlDbType.VarChar).Value = Distance;
            command.Parameters.Add("@pay", MySqlDbType.VarChar).Value = Payment;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = Price;

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
            MySqlCommand command = new MySqlCommand("DELETE FROM `routes` WHERE `id` = @id", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `routes` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = _ID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;

        }

    }
}
