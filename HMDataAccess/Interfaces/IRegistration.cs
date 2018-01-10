using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDataAccess.Interfaces
{
    interface IRegistration
    {
        void CreateUser(UserModel user);
        void UpdateUser();
        List<UserModel> GetUserList(int homeId);
        void DeleteUser();
    }
}
