using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManamentApp.Services
{
    // Veri tabanına bağlantı ve veri işlemleri için kullanılacak sınıf
    public static class Database
    {
        // C:\GitHub\InfoTech-MSCD-ENE-11\Modul05-FormUygulamalari\Week07\24-08-2026\HrManamentApp\hr_management.sqlite 
        public static string DbPath { get; } = Path.Combine(AppContext.BaseDirectory, "hr_management.sqlite");
        public static string ConnectionString { get; } = new SqliteConnectionStringBuilder
        {
            DataSource = DbPath,
            ForeignKeys = true,
            Mode = SqliteOpenMode.ReadWrite
        }.ToString();

        public static SqliteConnection OpenConnection()
        {
            if (!File.Exists(DbPath))// eğer db dosyamız yoksa
            {
                throw new FileNotFoundException($"hr_management.sqlite bulunamadı. Dosya proje klasöründe olmalı.", DbPath);
            }
            var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    
        public static int Execute(string commandText, Action<SqliteCommand>? bind = null)
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = commandText;
            bind?.Invoke(command);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (SqliteException ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
