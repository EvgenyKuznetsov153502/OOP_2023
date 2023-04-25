using FreightTransportation.WorkWithDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        public Request(string driver) : this()
        {
            this.driver= driver;
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

        public void SetDriver(string driver)
        {
            this.driver = driver;
        }

        public void SetCustomer(string cus)
        {
            customer = cus;
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

        public bool IsIdExists_Approved(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id AND `status` = @st", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = "approved";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool IsIdExists_InProcessing(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id AND `status` = @st", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = "in processing";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool IsIdExists_Completed(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id AND `status` = @st", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = "completed";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool IsIdExists(int _ID, string customer)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id AND `customer` = @cus", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;
            command.Parameters.Add("@cus", MySqlDbType.VarChar).Value = customer;

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

        public DataTable GetRequests()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetCustRequests()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `customer` = @cus", db.GetConnection());
            command.Parameters.Add("@cus", MySqlDbType.VarChar).Value = customer;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            table.Columns.RemoveAt(4);
            table.Columns.RemoveAt(4);
            return table;
        }

        public DataTable GetCompletedRequests()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `status` = @status", db.GetConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "completed";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            table.Columns.RemoveAt(6);
            return table;
        }



        public DataTable GetEmplRequests()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `status` = @status", db.GetConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "in processing";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            table.Columns.RemoveAt(4);
            table.Columns.RemoveAt(5);
            return table;
        }

        public DataTable GetApprovedRequests()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `status` = @status", db.GetConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "approved";

            adapter.SelectCommand = command;
            adapter.Fill(table);
                
            table.Columns.RemoveAt(6);
            return table;
        }



        public bool Remove(int _ID)
        {
            bool IsRemoved = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `requests` WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = _ID;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsRemoved = true;

            db.CloseConnection();

            return IsRemoved;
        }

        public bool Processing(string status, int _ID)
        {
            bool flag = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `requests` SET `driver` = @driver," +
                " `status` = @status WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@driver", MySqlDbType.VarChar).Value = driver;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;
        }

        public bool ChangeStatusToComplete(int _ID)
        {
            bool flag = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `requests` SET `status` = @status" +
                " WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "completed";
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;

        }

        public string GetRoute(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = _ID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row = table.Rows[0];
            string route = row["route"].ToString();
            return route;
        }

        public string GetDriver(int _ID)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = _ID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row = table.Rows[0];
            string driver = row["driver"].ToString();
            return driver;
        }

        public DataTable SearchByCustomer()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests` WHERE `customer` = @cus AND `status` = @st", db.GetConnection());

            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = "completed";
            command.Parameters.Add("@cus", MySqlDbType.VarChar).Value = customer;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            table.Columns.RemoveAt(6);
            return table;
        }

       


    }
}
