using HMModels.Models;

namespace HMBusiness.Interfaces
{
    interface IHome
    {
        int AddHome();
        void UpdateHome(HomeModel home);
        void DeleteHome(int homeId);
        HomeModel GetHome(int homeId);
    }
}
