using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HMBusiness
{
    public class Authentication
    {
        //Singleton Pattern

        private static Authentication instance = new Authentication();
        private Authentication() { }
        public static Authentication GetInstance()
        {
            return instance;
        }

        public UserModel GetUserInfoFromSession()
        {
            UserModel userInfo = (UserModel)HttpContext.Current.Session["UserInfo"];
            return userInfo;
        }

        public void GetAccessToPage()
        {
            if(GetUserInfoFromSession() == null)
            {
                HttpContext.Current.Response.Redirect("~/Login.aspx");
            }
            //otherwise do nothing, will continue...
        }
    }
}
