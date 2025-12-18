using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Exercise6_DesignAWorkflowEngine
{
    class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            //Add an activity to the activities list
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            // Remove activity from the activities list
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            // Return list of activities
            return _activities;
        }
    }
}
