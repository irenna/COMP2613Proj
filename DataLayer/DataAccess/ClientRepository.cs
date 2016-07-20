using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Common;

namespace DataLayer.DataAccess
{
    public class ClientRepository
    {
        private static string connectionString = "Server=tcp:s08.winhost.com;"
                                         + "Database=DB_15202_2614d162;"
                                         + "User ID=DB_15202_2614d162_user;"
                                         + "Password=93nu5#S67;"
                                         + "Integrated Security=False;";

        public static ClientCollection GetClients()
        {
            ClientCollection clients;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = string.Format("{0} {1} {2}"
                            , "SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes"
                            , "FROM Client903398"
                            , "ORDER BY CompanyName");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    clients = new ClientCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {

                        string clientCode;
                        string companyName;
                        string address1;
                        string address2;
                        string city;
                        string province;
                        string postalCode;
                        decimal ytdSales;
                        byte creditHold;
                        string notes;

                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                address2 = reader["Address2"] as string;
                            }
                            else
                            {
                                address2 = null;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;
                            }
                            else
                            {
                                city = null;
                            }

                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(5))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }
                            else
                            {
                                postalCode = null;
                            }

                            ytdSales = (decimal)reader["YTDSales"];
                            creditHold = (byte)reader["CreditHold"];
                            bool hasCreditHold = creditHold == 1;

                            if (!reader.IsDBNull(9))
                            {
                                notes = reader["Notes"] as string;
                            }
                            else
                            {
                                notes = null;
                            }

                            clients.Add(new Client
                            {
                                ClientCode = clientCode,
                                CompanyName = companyName,
                                Address1 = address1,
                                Address2 = address2,
                                City = city,
                                Province = province,
                                PostalCode = postalCode,
                                YtdSales = ytdSales,
                                CreditHold = hasCreditHold
                            });
                        }
                    }
                }

                return clients;

            }      
        }

        public static int AddClient(Client client) {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = string.Format("{0} {1} {2}"
                            , "INSERT INTO Client903398"
                            , "(ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)"
                            , "Values(@clientCode, @companyName, @address1, @address2, @city, @province, @postalCode, @ytdSales, @creditHold, @notes)");

                byte creditHold = client.CreditHold ? (byte)1 : (byte)0;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@creditHold", creditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }  
        }

        public static int UpdateClient(Client client)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}"
                                        , "UPDATE Client903398"
                                        , "SET CompanyName = @companyName"
                                        , ", Address1 = @address1"
                                        , ", Address2 = @address2"
                                        , ", City = @city"
                                        , ", Province = @province"
                                        , ", PostalCode = @postalCode"
                                        , ", YTDSales = @ytdSales"
                                        , ", CreditHold = @creditHold"
                                        , ", Notes = @notess"
                                        , "WHERE ClientCode = @clientCode");


                byte creditHold = client.CreditHold ? (byte)1 : (byte)0;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@creditHold", creditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }


        public static int DeleteClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // embedded SQL
                string query = string.Format("{0} {1}"
                                        , "DELETE Client903398"
                                        , "WHERE ClientCode = @clientCode");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

    }
}
