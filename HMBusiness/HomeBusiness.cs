using HMBusiness.Interfaces;
using HMDataAccess;
using HMModels.Models;
using System;

namespace HMBusiness
{
    public class HomeBusiness : IHome
    {
        private HomeModel homeModel;
        public HomeBusiness()
        { }
        public HomeBusiness(string homeName, string homeType)
        {
            homeModel = new HomeModel {
                Name = homeName,
                Type = homeType
            };
        }

        public int AddHome()
        {
            HomeOperations homeOps = new HomeOperations();
            homeModel = homeOps.CreateHome(homeModel);
            return homeModel.ID;
        }

        public void DeleteHome(int homeId)
        {
            throw new NotImplementedException();
        }

        public HomeModel GetHome(int homeId)
        {
            throw new NotImplementedException();
        }

        public void UpdateHome(HomeModel home)
        {
            throw new NotImplementedException();
        }
    }
}
