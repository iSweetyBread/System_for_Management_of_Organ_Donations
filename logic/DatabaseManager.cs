using logic.infoObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace logic
{
    public static class DatabaseManager
    {
        private static string connectionString = "Data Source=(localdb)\\localdb01;Initial Catalog=Organs;Integrated Security=True";

        public static void Create(SqlObject data)
        {
            var (tableName, tableValues, tableData) = GetTable(data);

            string query = $"insert into {tableName} ({tableValues}) values ({tableData})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (SqlParameter i in data.parameters)
                    {
                        command.Parameters.Add(i);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }
        public static List<Dictionary<string, object>> Read(int table)
        {
            string tableName = GetTable(table).Item1;

            string query = $"select * from {tableName}";

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }
                    }
                }
            }
            return result;
        }
        public static void Update(int table, int id, string attribute, string data)
        {
            string attributeVar = "@" + attribute;
            string tableName = GetTable(table).Item1;
            string idVar = GetTable(table).Item2.Split(',')[0];

            string query = $"update {tableName} set \"{attribute}\" = {attributeVar} where {idVar} = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue(attributeVar, data);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public static void Delete(int table, int id)
        {
            string tableName = GetTable(table).Item1;
            string idVar = GetTable(table).Item2.Split(',')[0];

            string query = $"delete from {tableName} where {idVar} = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public static List<Dictionary<string, object>> Search(int table, string attribute, string data)
        {
            string tableName = GetTable(table).Item1;

            string query = $"select * from {tableName} where {attribute} = \'{data}\'";

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }
                    }
                }
            }
            return result;
        }
        public static int MaxID(int table)
        {
            string tableName = GetTable(table).Item1;
            string idVar = GetTable(table).Item2.Split(',')[0];

            string query = $"select max({idVar}) from {tableName}";

            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try { result = reader.GetInt32(0); } catch { return result; }
                        }
                    }
                }
            }
            return result;
        }
        public static int GetCount(int id)
        {
            string query = $"select Donation_count from Blood_donor_info where Bdonor_id = {id}";

            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try { result = reader.GetInt32(0); } catch { return result; }
                        }
                    }
                }
            }
            return result;
        }
        private static (string, string, string) GetTable(SqlObject data)
        {
            string tableName, tableValues, tableData;

            switch (data.GetHashCode())
            {
                case 1:
                    tableName = "Donor_info";
                    tableValues = "Donor_id, First_name, Last_name, Birth_date, Blood_type, City, \"Address\"";
                    tableData = "@Donor_id, @First_name, @Last_name, @Birth_date, @Blood_type, @City, @Address";
                    break;
                case 2:
                    tableName = "Blood_donor_info";
                    tableValues = "Bdonor_id, First_name, Last_name, Birth_date, Blood_type, Donation_count, City, \"Address\"";
                    tableData = "@Bdonor_id, @First_name, @Last_name, @Birth_date, @Blood_type, @Donation_count, @City, @Address";
                    break;
                case 3:
                    tableName = "Receiver_info";
                    tableValues = "Receiver_id, First_name, Last_name, Birth_date, Blood_type, Organ_id, City, \"Address\", Hospital_id, Registration_date, Organ_status, \"Priority\"";
                    tableData = "@Receiver_id, @First_name, @Last_name, @Birth_date, @Blood_type, @Organ_id, @City, @Address, @Hospital_id, @Registration_date, @Organ_status, @Priority";
                    break;
                case 4:
                    tableName = "Blood_donation";
                    tableValues = "Bdonor_id, Donation_date, Amount, Place_id";
                    tableData = "@Bdonor_id, @Donation_date, @Amount, @Place_id";
                    break;
                case 5:
                    tableName = "Organ_donation";
                    tableValues = "Organ_id, Donor_id, Organ, Extraction_date, Place_id, \"Status\"";
                    tableData = "@Organ_id, @Donor_id, @Organ, @Extraction_date, @Place_id, @Status";
                    break;
                case 6:
                    tableName = "Hospital_info";
                    tableValues = "Hospital_id, City, \"Address\", Contact_info";
                    tableData = "@Hospital_id, @City, @Address, @Contact_info";
                    break;
                case 7:
                    tableName = "Bank_info";
                    tableValues = "Place_id, City, \"Address\", Contact_info";
                    tableData = "@Place_id, @City, @Address, @Contact_info";
                    break;
                case 8:
                    tableName = "Blood_amount";
                    tableValues = "Place_id, A_plus, A_minus, B_plus, B_minus, AB_plus, AB_minus, O_plus, O_minus";
                    tableData = "@Place_id, @A_plus, @A_minus, @B_plus, @B_minus, @AB_plus, @AB_minus, @O_plus, @O_minus";
                    break;
                default:
                    tableName = string.Empty;
                    tableValues = string.Empty;
                    tableData = string.Empty;
                    break;
            }

            return (tableName, tableValues, tableData);
        }
        private static (string, string, string) GetTable(int table)
        {
            string tableName, tableValues, tableData;

            switch (table)
            {
                case 1:
                    tableName = "Donor_info";
                    tableValues = "Donor_id, First_name, Last_name, Birth_date, Blood_type, City, \"Address\"";
                    tableData = "@Donor_id, @First_name, @Last_name, @Birth_date, @Blood_type, @City, @Address";
                    break;
                case 2:
                    tableName = "Blood_donor_info";
                    tableValues = "Bdonor_id, First_name, Last_name, Birth_date, Blood_type, Donation_count, City, \"Address\"";
                    tableData = "@Bdonor_id, @First_name, @Last_name, @Birth_date, @Blood_type, @Donation_count, @City, @Address";
                    break;
                case 3:
                    tableName = "Receiver_info";
                    tableValues = "Receiver_id, First_name, Last_name, Birth_date, Blood_type, Organ_id, City, \"Address\", Hospital_id, Registration_date, Organ_status, \"Priority\"";
                    tableData = "@Receiver_id, @First_name, @Last_name, @Birth_date, @Blood_type, @Organ_id, @City, @Address, @Hospital_id, @Registration_date, @Organ_status, @Priority";
                    break;
                case 4:
                    tableName = "Blood_donation";
                    tableValues = "Bdonor_id, Donation_date, Amount, Place_id";
                    tableData = "@Bdonor_id, @Donation_date, @Amount, @Place_id";
                    break;
                case 5:
                    tableName = "Organ_donation";
                    tableValues = "Organ_id, Donor_id, Organ, Extraction_date, Place_id, \"Status\"";
                    tableData = "@Organ_id, @Donor_id, @Organ, @Extraction_date, @Place_id, @Status";
                    break;
                case 6:
                    tableName = "Hospital_info";
                    tableValues = "Hospital_id, City, \"Address\", Contact_info";
                    tableData = "@Hospital_id, @City, @Address, @Contact_info";
                    break;
                case 7:
                    tableName = "Bank_info";
                    tableValues = "Place_id, City, \"Address\", Contact_info";
                    tableData = "@Place_id, @City, @Address, @Contact_info";
                    break;
                case 8:
                    tableName = "Blood_amount";
                    tableValues = "Place_id, \"A+\", \"A-\", \"B+\", \"B-\", \"AB+\", \"AB-\", \"O+\", \"O-\"";
                    tableData = "@Place_id, @A+, @A-, @B+, @B-, @AB+, @AB-, @O+, @O-";
                    break;
                default:
                    tableName = string.Empty;
                    tableValues = string.Empty;
                    tableData = string.Empty;
                    break;
            }

            return (tableName, tableValues, tableData);
        }
    }
}
