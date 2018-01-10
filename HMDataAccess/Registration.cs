using HMDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMData;
using HMModels.Models;

namespace HMDataAccess
{
    public class Registration : IRegistration
    {
        public void CreateUser(UserModel user)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var query = she.User.Where(x => x.UserName == user.UserName && x.HomeId == user.HomeId).FirstOrDefault();
                    
                    if (query == null)
                    {
                        she.User.Add(new User
                        {
                            Name = user.FirstName,
                            Surname = user.LastName,
                            UserName = user.UserName,
                            Password = user.Password,
                            HomeId = user.HomeId,
                            UserType = user.UserType
                        });
                        she.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("User exist!");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetUserList(int homeId)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var query = (from u in she.User
                                where u.HomeId == homeId
                                select new UserModel
                                {
                                    FirstName = u.Name,
                                    LastName = u.Surname,
                                    UserName = u.UserName,
                                    UserType = u.UserType,
                                    HomeId = u.HomeId,
                                    ID = u.Id
                                }).ToList();
                    return query;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
