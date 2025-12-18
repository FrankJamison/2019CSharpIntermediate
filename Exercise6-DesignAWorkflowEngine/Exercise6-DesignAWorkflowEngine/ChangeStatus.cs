using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6_DesignAWorkflowEngine
{
    class ChangeStatus : IActivity
    {
        public void Execute()
        {
            // Execute ChangeStatus activity
            Console.WriteLine("Changing the status of the video record in the database to “Processing”.");
        }
    }
}
