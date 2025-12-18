using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6_DesignAWorkflowEngine
{
    class SendNotificationEmail : IActivity
    {
        public void Execute()
        {
            // Execute SendNotificationEmail activity
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}
