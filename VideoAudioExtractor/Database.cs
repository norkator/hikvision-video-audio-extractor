using Npgsql;

namespace VideoAudioExtractor
{
    public class Database
    {
        // Database
        private NpgsqlConnection _connection = null;

        // Variables


        public Database(string connString)
        {
            OpenDatabaseConnection(connString);
        }


        private async void OpenDatabaseConnection(string connString)
        {
            _connection = new NpgsqlConnection(connString);
            await _connection.OpenAsync();
        }


        private async void InsertRecording()
        {
        }

        private async void GetRecordings()
        {
        }


        /*
         // Insert some data
        await using (var cmd = new NpgsqlCommand("INSERT INTO data (some_field) VALUES (@p)", conn))
        {
            cmd.Parameters.AddWithValue("p", "Hello world");
            await cmd.ExecuteNonQueryAsync();
        }

        // Retrieve all rows
        await using (var cmd = new NpgsqlCommand("SELECT some_field FROM data", conn))
        await using (var reader = await cmd.ExecuteReaderAsync())
            while (await reader.ReadAsync())
                Console.WriteLine(reader.GetString(0));
         */
    }
}