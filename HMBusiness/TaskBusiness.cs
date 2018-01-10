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
    public class TaskBusiness : ITask
    {
        private TaskModel taskModel;
        public TaskBusiness(string taskName, int userId, int homeId)
        {
            taskModel = new TaskModel();
            taskModel.Name = taskName;
            taskModel.ResponsibleUserId = userId;
            taskModel.HomeId = homeId;
        }

        public void DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public TaskModel GetTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<TaskModel> GetUserTasks(int userId)
        {
            throw new NotImplementedException();
        }

        public void SaveTask()
        {
            TaskOperations taskOps = new TaskOperations();
            taskOps.AddTask(taskModel);
        }

        public void UpdateTask(TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
