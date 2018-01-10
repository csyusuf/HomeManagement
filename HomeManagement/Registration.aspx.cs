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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ResponseMessage message = new ResponseMessage();
            try
            {
                HomeBusiness homeBusiness = new HomeBusiness(txbHomeName.Text, ddlHomeType.SelectedValue);
                int homeId = homeBusiness.AddHome();
                if (IsPasswordMatched())
                {
                    UserRegistration registerUser = new UserRegistration(txbUserName.Text, txbFirstName.Text, txbLastName.Text, txbPassword.Text, "Admin", homeId);
                    registerUser.AddUserToHome();
                    message.PrintSuccessMessage(spnMessage, "Admin user and home successfully created");
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
            if(txbPassword.Text.CompareTo(txbPasswordRepeat.Text) == 0)
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