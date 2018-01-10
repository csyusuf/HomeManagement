using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBusiness.Interfaces
{
    interface IActivity
    {
        void SaveActivity();
        void UpdateActivity();
        void DeleteActivity(int activityId);
        ActivityModel GetActivity(int activityId);
        List<ActivityModel> GetAllActivities(int homeId);
    }
}
