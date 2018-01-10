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
    public partial class Task : System.Web.UI.Page
    {
        Authentication authenticate = Authentication.GetInstance();

        protected void Page_Load(object sender, EventArgs e)
        {
            authenticate.GetAccessToPage();
            FillUserList();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                TaskBusiness task = new TaskBusiness(txbTaskName.Text, Convert.ToInt32(ddlUsers.SelectedValue), userInfo.HomeId);
                task.SaveTask();
                lblMessage.Text = "The Task successfully saved";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void FillUserList()
        {
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                UserRegistration register = new UserRegistration();

                ddlUsers.DataSource = register.GetUserInfoList(userInfo.HomeId);
                ddlUsers.DataBind();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                //Details will be written to log file.
            }
        }
    }
}