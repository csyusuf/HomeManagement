using HMBusiness;
using HMModels.Models;
using System;
using System.Web.UI;

namespace HomeManagement
{
    public partial class _Default : Page
    {
        Authentication authenticate = Authentication.GetInstance();

        protected void Page_Load(object sender, EventArgs e)
        {
            authenticate.GetAccessToPage();
            PrintBillReminds();
            PrintFoodReminds();
        }

        private BillBusiness BillReminder()
        {
            BillBusiness bill = new BillBusiness();
            UserModel userInfo = authenticate.GetUserInfoFromSession();
            bill.RemindThings = bill.GetRemindedThings(userInfo.HomeId);
            bill.Name = "Coming Bills";
            if (bill.RemindThings.Count == 0)
            {
                bill.Message = "No coming bills";
            }
            
            return bill;
        }

        private void PrintBillReminds()
        {
            BillBusiness billOps = BillReminder();
            foreach (var item in billOps.RemindThings)
            {
                BillModel bill = (BillModel)item;
                divBillInfo.InnerHtml += string.Format("<div class=\"row\">");
                divBillInfo.InnerHtml += string.Format("<div class=\"col-md-4\">{0}</div>",bill.BillType);
                divBillInfo.InnerHtml += string.Format("<div class=\"col-md-4\">{0}</div>", bill.Amount);
                divBillInfo.InnerHtml += string.Format("<div class=\"col-md-4\">{0}</div>", bill.PaymentDueDate.ToShortDateString());
                divBillInfo.InnerHtml += "</div>";
            }            
        }

        private FoodBusiness ConsumedFoodReminder()
        {
            FoodBusiness food = new FoodBusiness();
            UserModel userInfo = authenticate.GetUserInfoFromSession();
            food.RemindThings = food.GetRemindedThings(userInfo.HomeId);
            if (food.RemindThings.Count == 0)
            {
                food.Message = "Nothing consumed";
            }
            return food;
        }

        private void PrintFoodReminds()
        {
            FoodBusiness foodOps = ConsumedFoodReminder();
            foreach (var item in foodOps.RemindThings)
            {
                FoodModel food = (FoodModel)item;
                divFoodInfo.InnerHtml += "<div class=\"row\">";
                divFoodInfo.InnerHtml += string.Format("<div class=\"col-md-4\">{0}</div>", food.FoodName);
                divFoodInfo.InnerHtml += string.Format("<div class=\"col-md-4\">{0}</div>", food.BuyDate.ToShortDateString());
                divFoodInfo.InnerHtml += string.Format("<div class=\"col-md-4\">{0}</div>", food.ConsumedDate.ToShortDateString());
                divFoodInfo.InnerHtml += "</div>";
            }
        }
    }
}