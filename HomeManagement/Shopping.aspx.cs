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
    public partial class Shopping : System.Web.UI.Page
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
                ShoppingBusiness shopping = new ShoppingBusiness(txbShoppingItem.Text, Convert.ToInt32(ddlUserList.SelectedValue), userInfo.HomeId);
                shopping.SaveShoppingItem();
                spnMessage.InnerText = "Item successfully has been saved!";
                spnMessage.Attributes.Add("class", "label label-success");
            }
            catch (Exception ex)
            {
                spnMessage.InnerText = ex.Message;
                spnMessage.Attributes.Add("class","label label-danger");
            }
            
        }

        private void FillUserList()
        {
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                UserRegistration register = new UserRegistration();

                ddlUserList.DataSource = register.GetUserInfoList(userInfo.HomeId);
                ddlUserList.DataBind();
            }
            catch (Exception ex)
            {
                spnMessage.InnerText = ex.Message;
            }
        }
    }
}