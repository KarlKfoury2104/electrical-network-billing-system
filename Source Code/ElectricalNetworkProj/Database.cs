using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace ElectricalNetworkProj
{
    internal static class Database
    {
        private const string SchemaResourceName = "ElectricalNetworkProj.Schema.schema.sql";

        public static readonly string DatabaseDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ElectricalNetworkProj");

        public static readonly string DatabasePath = Path.Combine(
            DatabaseDirectory,
            "electrical_network.db");

        public static string ConnectionString
        {
            get
            {
                return "Data Source=" + DatabasePath + ";Version=3;Foreign Keys=True;";
            }
        }

        public static void Initialize()
        {
            Directory.CreateDirectory(DatabaseDirectory);

            if (!File.Exists(DatabasePath))
            {
                SQLiteConnection.CreateFile(DatabasePath);
            }

            string schemaSql = ReadEmbeddedSchema();

            string[] statements = schemaSql.Split(
                new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.Transaction = transaction;

                    foreach (string statement in statements)
                    {
                        string sql = statement.Trim();
                        if (sql.Length == 0)
                        {
                            continue;
                        }

                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
        }

        private static string ReadEmbeddedSchema()
        {
            Assembly assembly = typeof(Database).Assembly;

            using (Stream stream = assembly.GetManifestResourceStream(SchemaResourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException(
                        "Embedded SQLite schema was not found: " + SchemaResourceName);
                }

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
