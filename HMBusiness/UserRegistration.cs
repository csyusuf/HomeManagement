using HMDataAccess;
using HMModels.Models;
using System.Collections.Generic;

namespace HMBusiness
{
    public class UserRegistration
    {
        private UserModel userModel;
        public UserRegistration() { }
        public UserRegistration(string userName, string firstName, string lastName, string password, string userType, int homeId)
        {
            userModel = new UserModel{
                UserName = userName,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                UserType = userType,
                HomeId = homeId
            };
        }

        public void AddUserToHome()
        {
            Registration register = new Registration();
            register.CreateUser(userModel);
        }

        public List<UserModel> GetUserInfoList(int homeId)
        {
            Registration register = new Registration();
            List<UserModel> userInfoList = register.GetUserList(homeId);
            return userInfoList;
        }

    }
}
