using HMBusiness;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeManagement
{
    public partial class SiteMaster : MasterPage
    {
        Authentication authenticate = Authentication.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserModel userInfo = authenticate.GetUserInfoFromSession();
            if (userInfo != null)
            {
                lnkLogout.Visible = true;
                lnkLogin.Visible = false;
                lnkCreateUser.Visible = true;
                lnkRegistration.Visible = false;
            }
            else
            {
                lnkLogout.Visible = false;
                lnkLogin.Visible = true;
                lnkCreateUser.Visible = false;
                lnkRegistration.Visible = true;
            }
        }
    }
}