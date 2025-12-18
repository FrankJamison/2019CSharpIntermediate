using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6_DesignAWorkflowEngine
{
    class UploadVideo : IActivity
    {
        public void Execute()
        {
            // Execute UploadVideo activity
            Console.WriteLine("Uploading video to a cloud storage.");
        }
    }
}
