using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDataAccess.Interfaces
{
    interface ILogin
    {
        UserModel GetUserFromDB(string userName, string password);
    }
}
