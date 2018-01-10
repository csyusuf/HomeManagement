using HMDataAccess;
using System.Web;
using HMModels.Models;
using HMBusiness.Interfaces;

namespace HMBusiness
{
    public class LoginBusiness : ILogin
    {
        private string UserName { get; set; }
        private string Password { get; set; }

        public LoginBusiness(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public void LoginUser()
        {
            Login loginProcess = new Login();
            UserModel userInfo = loginProcess.GetUserFromDB(UserName, Password);
            HttpContext.Current.Session["UserInfo"] = userInfo;
        }
    }
}
