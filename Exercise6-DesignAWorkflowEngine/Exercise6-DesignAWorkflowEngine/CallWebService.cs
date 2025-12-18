using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6_DesignAWorkflowEngine
{
    class CallWebService : IActivity
    {
        public void Execute()
        {
            // Execute CallWebService activity
            Console.WriteLine("Calling third-party video encoding web service service to tell them a video is ready for encoding.");
        }
    }
}
