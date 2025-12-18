using System.Collections.Generic;

namespace Exercise6_DesignAWorkflowEngine
{
    public interface IWorkflow
    {
        // AddActivity method required for all workflow objects
        void AddActivity(IActivity activity);
        // RemoveActivity method required for all workflow objects
        void RemoveActivity(IActivity activity);
        // GetActivities method required for all workflow objects
        IEnumerable<IActivity> GetActivities();
    }
}