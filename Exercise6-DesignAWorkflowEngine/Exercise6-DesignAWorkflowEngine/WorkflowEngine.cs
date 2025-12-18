using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercise6_DesignAWorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            // For each activity in the workflow, execute the activity
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
