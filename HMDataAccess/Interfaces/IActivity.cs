using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDataAccess.Interfaces
{
    interface IActivity
    {
        void AddActivity(ActivityModel activityModel);
        void DeleteActivity(int activityId);
        void UpdateActivity(ActivityModel activityModel);
        void GetActivity(int activityId);
        List<ActivityModel> GetAllActivities(int homeId);
    }
}
