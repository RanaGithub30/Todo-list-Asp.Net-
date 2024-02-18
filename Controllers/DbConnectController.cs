using System;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

public class DbConnectController : Controller
{
    protected void ConnectToPostgreSQL()
    {
        string connString = "Server=localhost;Port=5432;Database=todo;User Id=postgres;Password=root;";

        using (NpgsqlConnection conn = new NpgsqlConnection(connString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected to PostgreSQL!");

                // Execute SQL queries or other database operations here
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("PostgreSQL Error: " + ex.Message);
            }
        }
    }
}
