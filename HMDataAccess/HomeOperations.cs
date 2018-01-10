using HMDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMModels.Models;
using HMData;

namespace HMDataAccess
{
    public class HomeOperations : IHome
    {
        public HomeModel CreateHome(HomeModel homeModel)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                if(!IsHomeNameExist(homeModel.Name))
                {
                   Home home = she.Home.Add(new Home {
                        Name = homeModel.Name,
                        Type = homeModel.Type
                    });
                    she.SaveChanges();
                    homeModel.ID = home.Id;
                    return homeModel;
                }
                else
                {
                    throw new Exception("Home name is already exist. Choose another name!");
                }
            }
        }

        public void DeleteHome(int homeId)
        {
            throw new NotImplementedException();
        }

        private bool IsHomeNameExist(string homeName)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                var home = she.Home.Where(x=>x.Name == homeName).FirstOrDefault();
                if (home != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
