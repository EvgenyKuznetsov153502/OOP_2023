using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreightTransportation.WorkWithDB
{
    internal class UniqueCode
    {
        private string Code;
        private string AdminCode = "Admin";

        public UniqueCode() { Code = string.Empty; }
        public UniqueCode(string code) { this.Code = code;}

        public string GetAdminCode()
        {
            return AdminCode;
        }

        public bool IsCodeExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `unique_passwords` WHERE `password` = @uP", db.GetConnection());
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
            MySqlCommand command = new MySqlCommand("DELETE FROM `unique_passwords` WHERE `password` = @Uc", db.GetConnection());

            command.Parameters.Add("@Uc", MySqlDbType.VarChar).Value = Code;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1) 
                IsCreated = true;

            db.CloseConnection();

            return IsCreated;
 
        }

    }
}
