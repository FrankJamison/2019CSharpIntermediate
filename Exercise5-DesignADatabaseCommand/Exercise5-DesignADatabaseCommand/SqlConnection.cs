using System;

namespace Exercise5_DesignADatabaseCommand
{
    class SqlConnection : DbConnection
    {
        private bool SqlConnectionOpen;

        /*
         * --- CONSTRUCTOR: SqlConnection ---
         * Requires: connection string
         * Sets: Connection open flag
         */
        public SqlConnection(string connectionString) : base(connectionString)
        {
            // Set the SQL Connection Open flag to false
            SqlConnectionOpen = false;
        }

        /*
         * --- METHOD: OpenConnection ---
         * Overrides method in DbConnection class
         * Used to open an Oracle database connection
         */
        public override void OpenConnection()
        {
            try
            {
                // If a connection is already open, throw an ex exception
                if (SqlConnectionOpen)
                {
                    throw new InvalidOperationException("SqlConnectionOpen");
                }

                // Open the connection
                Console.WriteLine("Connecting to SQL database...");
                SqlConnectionOpen = true;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("An SQL database connection is already open.");
            }
        }

        /*
         * --- METHOD: CloseConnection ---
         * Overrides method in DbConnection class
         * Used to close the Oracle database connection
         */
        public override void CloseConnection()
        {
            try
            {
                // If the connection is already closed, throw an exception
                if (!SqlConnectionOpen)
                {
                    throw new InvalidOperationException("ConnectionOpen");
                }

                Console.WriteLine("Closing SQL database connection...");
                SqlConnectionOpen = false;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("An SQL database connection is not currently open.");
            }
        }
    }
}