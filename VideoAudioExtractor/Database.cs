using System;
using System.Data;
using System.Globalization;
using System.Threading.Tasks;
using Npgsql;

namespace VideoAudioExtractor
{
    public class Database
    {
        // Database
        private NpgsqlConnection _connection = null;

        // Variables
        private readonly string _connString;

        public Database(string connString)
        {
            _connString = connString;
        }


        public async Task<bool> OpenDatabaseConnection()
        {
            _connection = new NpgsqlConnection(_connString);
            await _connection.OpenAsync();
            return (_connection.State & ConnectionState.Open) != 0;
        }


        private async void InsertRecording()
        {
        }

        private async void GetRecordings()
        {
        }

        public async Task<String> GetLastRecordingEndTime()
        {
            string lastRecording = null;
            await using var cmd = new NpgsqlCommand(
                "SELECT end_time FROM recordings ORDER BY end_time DESC LIMIT 1", _connection);
            var reader = await cmd.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    lastRecording = reader.GetDateTime(0).ToString(CultureInfo.InvariantCulture);
                }
                return lastRecording;
            }
            else
            {
                return null;
            }
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