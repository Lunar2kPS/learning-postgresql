using System;
using System.Threading.Tasks;
using Npgsql;

namespace CSharpPostgreSQLExample {
    public class Program {
        public static async Task Main(string[] args) {
            Console.WriteLine("Hello, World!");

            string connectionString = "Host=localhost:5432;Username=root;Password=root;Database=\"Learning PostgreSQL\"";
            await using NpgsqlConnection connection = new(connectionString); //NOTE: `await using` here because NpgsqlConnection is IAsyncDisposable instead of just regular IDisposable.
            await connection.OpenAsync();

            await using (NpgsqlCommand cmd = new("SELECT * FROM players;", connection))
            await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync()) {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(string.Format("{0,-20}", reader.GetName(i)));
                Console.WriteLine();

                while (await reader.ReadAsync()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        object value = reader.IsDBNull(i) ? null : reader.GetValue(i);
                        Console.Write(string.Format("{0,-20}", value == null ? "NULL" : value.ToString()));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
