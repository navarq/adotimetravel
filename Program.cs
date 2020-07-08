using System;
using Npgsql;

namespace adotimetravel
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "User Id=timetraveller;Password=NH1b32thefree;Host=localhost;Database=timetravelmovies;Persist Security Info=True";

            // Provide the query string with a parameter place holder

            string queryString = "SELECT movieid, name, releasedate, mainactor from movies order by releasedate desc";

            // Result of code execution or number of lines?
            int result = 0;
            using (NpgsqlConnection pgConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(queryString, pgConnection);
                
                try
                {
                    pgConnection.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    pgConnection.Close();
                }
            }

            Console.WriteLine("End of Program");
        }
    }
}
