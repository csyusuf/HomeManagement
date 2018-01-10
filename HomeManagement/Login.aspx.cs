using HMBusiness;
using HMHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness loginBusiness = new LoginBusiness(txbUserName.Text, txbPassword.Text);
                loginBusiness.LoginUser();
                Response.Redirect("~/Default.aspx");
            }
            catch (Exception ex)
            {
                ResponseMessage message = new ResponseMessage();
                message.PrintFailureMessage(spnMessage, ex.Message);
            }
            
        }
    }
}