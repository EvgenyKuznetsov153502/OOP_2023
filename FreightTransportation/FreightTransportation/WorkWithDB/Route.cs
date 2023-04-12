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



    }
}
