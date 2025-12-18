using System;

namespace Exercise5_DesignADatabaseCommand
{
    class DbCommand
    {
        private readonly DbConnection _connection;      // Database connection
        private readonly string _instruction;           // Database instruction
        private readonly bool _okToProcess;             // OK to process flag

        /*
         * --- CONSTRUCTOR ---
         * Requires: connection string, instruction
         * Initializes all class fields
         */
        public DbCommand(DbConnection connection, string instruction)
        {
            try
            {
                // If the connection string is null or whitespace, throw exception
                if (connection is null)
                {
                    throw new InvalidOperationException("connection");
                }

                // If the instruction is null or whitespace, throw exception
                if (string.IsNullOrWhiteSpace(instruction))
                {
                    throw new InvalidOperationException("instruction");
                }

                // Set DbCommand fields
                _connection = connection;
                _instruction = instruction;
                _okToProcess = true;
            }

            catch (Exception e)
            {
                var message = e.Message;        // Exception message

                switch (message)
                {
                    // If the exception is caused by the connection string, display error and mark as not ok to process
                    case ("connection"):
                        Console.WriteLine("There is no connection for the database to use.");
                        _okToProcess = false;
                        break;

                    // If the exception is caused by the database instruction, display error and mark as not ok to process
                    case ("instruction"):
                        Console.WriteLine("There is no instruction for the database to execute.");
                        _okToProcess = false;
                        break;

                    // If the error thrown is not defined, display generic error and mark as not ok to process
                    default:
                        Console.WriteLine("An unknown error has occurred.");
                        Console.WriteLine(message);
                        _okToProcess = false;
                        break;
                }
            }
        }

        /*
         * --- METHOD: Execute ---
         * Used to connect to the database and execute the instruction,
         * then close the connection
         */
        public void Execute()
        {
            if (_okToProcess)
            {
                _connection.OpenConnection();
                Console.WriteLine(_instruction);
                _connection.CloseConnection();
            }
        }
    }
}