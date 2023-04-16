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
    internal class UniqueCode
    {
        private string Code;
        private string AdminCode = "Admin";
        private char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        public UniqueCode() { Code = string.Empty; }
        public UniqueCode(string code) { this.Code = code;}

        public string GetAdminCode()
        {
            return AdminCode;
        }

        public void SetCode(string code)
        {
            Code = code;
        }

        public bool IsCodeExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `unique_passwords` WHERE `codes` = @uP", db.GetConnection());
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Code;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
       
        public bool  CodeRemoval()
        {
            bool IsCreated = false;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `unique_passwords` WHERE `codes` = @Uc", db.GetConnection());

            command.Parameters.Add("@Uc", MySqlDbType.VarChar).Value = Code;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1) 
                IsCreated = true;

            db.CloseConnection();

            return IsCreated;
 
        }

        public DataTable Get()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `unique_passwords`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool AddCode()
        {
            bool IsAdded = false;
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `unique_passwords` (`codes`) VALUES (@code)", db.GetConnection());

            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = Code;
          
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
            MySqlCommand command = new MySqlCommand("DELETE FROM `unique_passwords` WHERE `id` = @id", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `unique_passwords` WHERE `id` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _ID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RandomCode(int length = 8)
        {
            Random rand = new Random();

            string code = "";
            for (int j = 1; j <= length; j++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                code += letters[letter_num];
            }

            return code;
        }






    }
}
