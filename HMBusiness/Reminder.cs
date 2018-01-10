using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBusiness
{
    public class Reminder
    {
        public Reminder()
        { }

        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime ReminderDate { get; set; }
        public List<object> RemindThings { get; set; }

        public virtual List<object> GetRemindedThings(int homeId)
        {
            return new List<object>();
        }
    }
}
