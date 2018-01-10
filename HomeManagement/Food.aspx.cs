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
    public partial class Food : System.Web.UI.Page
    {
        Authentication authenticate = Authentication.GetInstance();

        protected void Page_Load(object sender, EventArgs e)
        {
            authenticate.GetAccessToPage();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel userInfo = authenticate.GetUserInfoFromSession();
                FoodBusiness food = new FoodBusiness(txbFoodName.Text, Convert.ToDateTime(txbBuyDate.Text), Convert.ToDateTime(txbBestBeforeDate.Text), userInfo.HomeId);
                food.SaveFood();
                spnMessage.InnerText = "Food successfully has been saved!";
                spnMessage.Attributes.Add("class","label label-success");
            }
            catch (Exception ex)
            {
                spnMessage.InnerText = ex.Message;
                spnMessage.Attributes.Add("class", "label label-danger");
            }
            
        }
    }
}