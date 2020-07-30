﻿using System;
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


        public async Task<bool> InsertRecording(Recording recording)
        {
            // Insert some data
            await using var cmd = new NpgsqlCommand( // Todo: populate camera name field later...
                "INSERT INTO recordings (file_name, start_time, end_time) VALUES (@fn, @st, @et)",
                _connection);
            cmd.Parameters.AddWithValue("fn", recording.GetFileName());
            cmd.Parameters.AddWithValue("st", recording.GetStartTime());
            cmd.Parameters.AddWithValue("et", recording.GetEndTime());
            await cmd.ExecuteNonQueryAsync();
            return cmd.Transaction.IsCompleted;
        }


        public async Task<DateTime> GetLastRecordingEndTime()
        {
            DateTime lastRecording = new DateTime();
            await using var cmd = new NpgsqlCommand(
                "SELECT end_time FROM recordings ORDER BY end_time DESC LIMIT 1", _connection);
            var reader = await cmd.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    lastRecording = reader.GetDateTime(0);
                }

                return lastRecording;
            }
            else
            {
                return lastRecording;
            }
        }
    }
}