using System;
using System.Linq;
using HMData;
using HMModels.Models;
using HMDataAccess.Interfaces;

namespace HMDataAccess
{
    public class Login : ILogin
    {
        public Login()
        {

        }

        public UserModel GetUserFromDB(string userName, string password)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var userInfo = she.User.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
                    if (userInfo != null)
                    {
                        return new UserModel
                        {
                            FirstName = userInfo.Name,
                            LastName = userInfo.Surname,
                            UserName = userInfo.UserName,
                            ID = userInfo.Id,
                            HomeId = userInfo.HomeId,
                            UserType = userInfo.UserType
                        };
                    }
                    else
                    {
                        throw new Exception("User name or password is wrong");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
