using HMData;
using HMDataAccess.Interfaces;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDataAccess
{
    public class ActivityOperations : IActivity
    {
        public ActivityOperations()
        { }

        public void AddActivity(ActivityModel activityModel)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var activity = she.Activity.Add(new Activity {
                        HomeId = activityModel.HomeId,
                        Name = activityModel.Name,
                        PlannedDate = activityModel.PlannedDate,
                        Attendees = activityModel.AttendeesString
                    });

                    she.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void DeleteActivity(int activityId)
        {
            throw new NotImplementedException();
        }

        public void GetActivity(int activityId)
        {
            throw new NotImplementedException();
        }

        public List<ActivityModel> GetAllActivities(int homeId)
        {
            throw new NotImplementedException();
        }

        public void UpdateActivity(ActivityModel activityModel)
        {
            throw new NotImplementedException();
        }
    }
}
