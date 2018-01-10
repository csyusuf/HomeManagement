using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBusiness.Interfaces
{
    interface ITask
    {
        void SaveTask();
        void UpdateTask(TaskModel task);
        void DeleteTask(int taskId);
        TaskModel GetTask(int taskId);
        List<TaskModel> GetUserTasks(int userId);
    }
}
