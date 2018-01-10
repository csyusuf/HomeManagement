using HMModels.Models;
using System.Collections.Generic;

namespace HMBusiness.Interfaces
{
    interface IRegistration
    {
        void AddUserToHome();
        List<UserModel> GetUserInfoList(int homeId);
    }
}
