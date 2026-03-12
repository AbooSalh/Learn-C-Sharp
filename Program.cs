namespace LearnCS
{
    using LearnCS.Project_Euler;
    using Microsoft.Data.SqlClient;

    internal class Program
    {
        static void Main(string[] args)
        {
            //DataBase();
            Console.WriteLine(Cryptograpghy.XORCipher("Hello World!", "myd"));
            Thread.Sleep(10000);
            Console.WriteLine(Cryptograpghy.XORCipher("Hello World!", "myd"));

        }

        private static void DataBase()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=test;
                                        Integrated Security=True;
                                        Persist Security Info=False;
                                        Pooling=False;
                                        MultipleActiveResultSets=False;
                                        Encrypt=True;
                                        TrustServerCertificate=False;
                                        Application Name=""SQL Server Management Studio"";
                                        Command Timeout=0";
            SqlConnection connection = new(connectionString);
            connection.Open();
            Console.WriteLine("Connection opened successfully.");
            SqlCommand command = new()
            {
                Connection = connection,
                CommandText = "SELECT TOP 10 * FROM dbo.Users"
            };
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    Console.WriteLine(reader.GetString(0));
            }
        }
    }
}