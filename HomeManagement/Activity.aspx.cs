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
    public partial class Activity : System.Web.UI.Page
    {
        Authentication authenticate = Authentication.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            authenticate.GetAccessToPage();
            FillUserList();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ResponseMessage message = new ResponseMessage();
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                List<int> selectedUsers = GetSelectedUsers();
                ActivityPlanningBusiness activityPlan = new ActivityPlanningBusiness(txbName.Text, Convert.ToDateTime(txbDate.Text), selectedUsers, userInfo.HomeId);
                activityPlan.SaveActivity();
                message.PrintSuccessMessage(spnMessage, "Activity successfully saved");
            }
            catch (Exception ex)
            {
                message.PrintFailureMessage(spnMessage, ex.Message);
            }
        }

        private void FillUserList()
        {
            ResponseMessage message = new ResponseMessage();
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                UserRegistration register = new UserRegistration();

                cblAttendees.DataSource = register.GetUserInfoList(userInfo.HomeId);
                cblAttendees.DataBind();
            }
            catch (Exception ex)
            {
                message.PrintFailureMessage(spnMessage, ex.Message);
            }
        }

        private List<int> GetSelectedUsers()
        {
            List<int> selectedUsers = new List<int>();
            foreach (ListItem item in cblAttendees.Items)
            {
                if (item.Selected)
                {
                    selectedUsers.Add(Convert.ToInt32(item.Value));
                }
            }

            return selectedUsers;
        }
    }
}