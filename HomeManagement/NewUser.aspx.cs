using HMBusiness;
using HMHelper;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeManagement
{
    public partial class NewUser : System.Web.UI.Page
    {
        Authentication authenticate = Authentication.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            authenticate.GetAccessToPage();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ResponseMessage message = new ResponseMessage();
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                if (IsPasswordMatched())
                {
                    UserRegistration registerUser = new UserRegistration(txbUserName.Text, txbFirstName.Text, txbLastName.Text, txbPassword.Text, ddlUserType.SelectedItem.Text, userInfo.HomeId);
                    registerUser.AddUserToHome();
                    message.PrintSuccessMessage(spnMessage, string.Format("{0} user and home successfully created",ddlUserType.SelectedItem.Text));
                }
                else
                {
                    message.PrintFailureMessage(spnMessage, "Password didn't matched!");
                }
            }
            catch (Exception ex)
            {
                message.PrintFailureMessage(spnMessage, ex.Message);
            }
        }

        private bool IsPasswordMatched()
        {
            if (txbPassword.Text.CompareTo(txbPasswordRepeat.Text) == 0)
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