using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDataAccess.Interfaces
{
    interface IHome
    {
        HomeModel CreateHome(HomeModel homeModel);
        void DeleteHome(int homeId);
    }
}
