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
    public partial class Bill : System.Web.UI.Page
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
                BillBusiness bill = new BillBusiness(ddlBillType.SelectedValue, Convert.ToDecimal(txbAmount.Text), Convert.ToDateTime(txbPaymentDueDate.Text), userInfo.HomeId);
                bill.SaveBill();
                message.PrintSuccessMessage(spnMessage, "Bill successfully has been saved");
            }
            catch (Exception ex)
            {
                message.PrintFailureMessage(spnMessage, ex.Message);
            }
        }
    }
}