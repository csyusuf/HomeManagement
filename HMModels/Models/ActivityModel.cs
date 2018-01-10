using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMModels.Models
{
    public class ActivityModel : CommonModel
    {
        public string Name { get; set; }
        public DateTime PlannedDate { get; set; }
        public List<int> Attendees { get; set; }
        public string AttendeesString { get; set; }

        public string GetAttendeesListAsString()
        {
            string userList = string.Empty;
            foreach (var item in Attendees)
            {
                userList += item + ",";
            }
            userList.TrimEnd(',');
            return userList;
        }
    }
}
