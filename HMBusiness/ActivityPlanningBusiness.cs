using HMBusiness.Interfaces;
using HMDataAccess;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBusiness
{
    public class ActivityPlanningBusiness : IActivity
    {
        private ActivityModel activityModel;

        public ActivityPlanningBusiness() { }
        public ActivityPlanningBusiness(string name, DateTime plannedDate, List<int> attendees, int homeId)
        {
            activityModel = new ActivityModel();
            activityModel.Name = name;
            activityModel.PlannedDate = plannedDate;
            activityModel.Attendees = attendees;
            activityModel.AttendeesString = activityModel.GetAttendeesListAsString();
            activityModel.HomeId = homeId;
        }

        public void DeleteActivity(int activityId)
        {
            throw new NotImplementedException();
        }

        public ActivityModel GetActivity(int activityId)
        {
            throw new NotImplementedException();
        }

        public List<ActivityModel> GetAllActivities(int homeId)
        {
            throw new NotImplementedException();
        }

        public void SaveActivity()
        {
            ActivityOperations activityOps = new ActivityOperations();
            activityOps.AddActivity(activityModel);
        }

        public void UpdateActivity()
        {
            throw new NotImplementedException();
        }
    }
}
