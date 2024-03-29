﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public Driver(string name, string OnRoute = "Yes") : this()
        {
            this.name = name;
            this.OnRoute = OnRoute;
        }

        public Driver(string name, int experience, string telephone, int payment = 0, string OnRoute = "No")
        {   
            this.experience = experience;
            this.payment = payment;
            this.name = name;
            this.telephone = telephone;
            this.OnRoute = OnRoute;
        }

        public void SetName(string name)
        {
            this.name = name;
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

        public DataTable GetDriversToPayment()
        {
            DataTable table = GetDrivers();
            table.Columns.RemoveAt(2);
            table.Columns.RemoveAt(4);
            return table;
        }

        public DataTable GetFreeDrivers()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `drivers` WHERE `OnRoute` = @answer",
                db.GetConnection());

            command.Parameters.Add("@answer", MySqlDbType.VarChar).Value = "No";

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

        public bool SendingOnTheRoad()
        {
            bool flag = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `drivers` SET `OnRoute` = @On" +
                " WHERE `name` = @name", db.GetConnection());

            command.Parameters.Add("@On", MySqlDbType.VarChar).Value = "Yes";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;
        }

        public bool Payment(int money)
        {
            bool flag = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `drivers` SET `payment` = `payment` + @money," +
                " `OnRoute` = @an WHERE `name` = @name", db.GetConnection());

            command.Parameters.Add("@money", MySqlDbType.Int32).Value = money;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@an", MySqlDbType.VarChar).Value = "No";

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;
        }

        public bool PaymentToZero(int _ID)
        {
            bool flag = false;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `drivers` SET `payment` = @pay" +
                " WHERE `id` = @id", db.GetConnection());

            command.Parameters.Add("@pay", MySqlDbType.Int32).Value = 0;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                flag = true;

            db.CloseConnection();

            return flag;
        }






    }
}
