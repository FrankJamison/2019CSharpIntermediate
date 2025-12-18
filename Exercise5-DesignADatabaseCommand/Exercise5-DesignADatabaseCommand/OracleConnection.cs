using System;

namespace Exercise5_DesignADatabaseCommand
{
    class OracleConnection : DbConnection
    {
        private bool OracleConnectionOpen;        // Open Connection Flag

        /*
         * --- CONSTRUCTOR ---
         * Requires: connection string
         * Sets: Connection open flag
         */
        public OracleConnection(string connectionString) : base(connectionString)
        {
            OracleConnectionOpen = false;
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
                if (OracleConnectionOpen)
                {
                    throw new InvalidOperationException("ConnectionOpen");
                }

                // Open the connection
                Console.WriteLine("Connecting to Oracle database...");
                OracleConnectionOpen = true;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("An Oracle database connection is already open.");
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
                if (!OracleConnectionOpen)
                {
                    throw new InvalidOperationException("ConnectionOpen");
                }

                Console.WriteLine("Closing Oracle database connection...");
                OracleConnectionOpen = false;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("An Oracle database connection is not currently open.");
            }
        }
    }
}