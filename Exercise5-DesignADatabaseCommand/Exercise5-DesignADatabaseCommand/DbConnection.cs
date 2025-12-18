using System;

namespace Exercise5_DesignADatabaseCommand
{
    abstract class DbConnection
    {
        internal string ConnectionString;      // Connection string
        private TimeSpan _timeout;             // Connection timeout period

        /*
         * --- CONSTRUCTOR ---
         * Constructor requires a connection string and sets timeout to 30 seconds
         */
        public DbConnection(string connectionString)
        {
            try
            {
                // If the connection string is null or whitespace, throw an exception.
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidOperationException("connectionString");
                }

                // Set the connection string value
                ConnectionString = connectionString;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("The database connection string cannot be null or whitespace.");
            }

            // Set timeout to 30 seconds
            _timeout = new TimeSpan(0,0,30);
        }

        // Abstract methods that will be overridden by derived classes
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}