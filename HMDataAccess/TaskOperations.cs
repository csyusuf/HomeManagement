using HMData;
using HMModels.Models;
using System;

namespace HMDataAccess
{
    public class TaskOperations
    {
        public TaskOperations() { }
        public void AddTask(TaskModel taskModel)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var task = she.Task.Add(new HMData.Task {
                        Name = taskModel.Name,
                        ResponsibleUserId = taskModel.ResponsibleUserId,
                        HomeId = taskModel.HomeId
                    });
                    she.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
