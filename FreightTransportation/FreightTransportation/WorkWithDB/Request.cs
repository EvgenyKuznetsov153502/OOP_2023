using FreightTransportation.WorkWithDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FreightTransportation
{
    public class Request
    {
        string route, loading, unloading, driver, customer, status;
        public Request()
        {
            route= string.Empty;
            loading= string.Empty;
            unloading= string.Empty;
            driver= string.Empty;
            customer= string.Empty;
            status= string.Empty;
        }

        public Request(string route, string loading, string unloading, string customer, string status)
        {
            this.route = route;
            this.loading = loading;
            this.unloading = unloading;
            this.customer = customer;
            this.status = status;
            driver = string.Empty;
        }

        public Request(string route, string loading, string unloading, string driver,
            string customer, string status) : this(route, loading, unloading, customer, status)
        {
            this.driver = string.Empty;
        }

        public bool IsIdExists(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }


        public bool SendRequest()
        {
            bool IsSend = false;
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `requests` (`route`, `loading`, `unloading`, `customer`, `status`, `driver`) VALUES (@route, @load, @unload, @cus, @status, @dr)", db.GetConnection());

            command.Parameters.Add("@route", MySqlDbType.VarChar).Value = route;
            command.Parameters.Add("@load", MySqlDbType.VarChar).Value = loading;
            command.Parameters.Add("@unload", MySqlDbType.VarChar).Value = unloading;
            command.Parameters.Add("@cus", MySqlDbType.VarChar).Value = customer;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@dr", MySqlDbType.VarChar).Value = string.Empty;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsSend = true;

            db.CloseConnection();

            return IsSend;
        }

        public bool IsRequestExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `route` = @route AND" +
                " `loading` = @load AND `unloading` = @unload AND `customer` = @cus", db.GetConnection());

            command.Parameters.Add("@route", MySqlDbType.VarChar).Value = route;
            command.Parameters.Add("@load", MySqlDbType.VarChar).Value = loading;
            command.Parameters.Add("@unload", MySqlDbType.VarChar).Value = unloading;
            command.Parameters.Add("@cus", MySqlDbType.VarChar).Value = customer;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
