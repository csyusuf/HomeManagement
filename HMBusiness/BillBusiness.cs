using HMBusiness.Interfaces;
using HMDataAccess;
using HMModels.Models;
using System;
using System.Collections.Generic;

namespace HMBusiness
{
    public class BillBusiness : Reminder, IBill
    {
        private BillModel billModel;
        public BillBusiness()
        { }
        public BillBusiness(string type, decimal amount, DateTime dueDate, int homeId)
        {
            billModel = new BillModel {
                BillType = type,
                Amount = amount,
                PaymentDueDate = dueDate,
                HomeId = homeId
            };
        }

        public void DeleteBill(int id)
        {
            throw new NotImplementedException();
        }

        public void GetBill(int id)
        {
            throw new NotImplementedException();
        }

        public List<BillModel> GetUnPaidBills(int homeId)
        {
            BillOperations billOps = new BillOperations();
            return billOps.GetBillNotPaid(homeId);
        }

        public void SaveBill()
        {
            BillOperations billOps = new BillOperations();
            billOps.SaveBill(billModel);
        }

        public void UpdateBill()
        {
            throw new NotImplementedException();
        }

        public override List<Object> GetRemindedThings(int homeId)
        {
            List<BillModel> unpaidBills = GetUnPaidBills(homeId);
            List<object> shouldRemindedBills = new List<object>();
            
            foreach (var item in unpaidBills)
            {
                //A condition may placed here
                //if(DateTime.Now.AddDays(1).CompareTo(item.PaymentDueDate) >= 0)
                //{
                    shouldRemindedBills.Add(item);
                //}
            }
            return shouldRemindedBills;
        }
    }
}
