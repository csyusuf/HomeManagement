using HMData;
using HMDataAccess.Interfaces;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HMDataAccess
{
    public class BillOperations : IBill
    {
        public BillOperations()
        {
        }

        public void SaveBill(BillModel billModel)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var bill = she.Bill.Add(new Bill
                    {
                        Type = billModel.BillType,
                        Amount = billModel.Amount,
                        HomeId = billModel.HomeId,
                        PaymentDueDate = billModel.PaymentDueDate
                    });

                    she.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<BillModel> GetBillNotPaid(int homeId)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var query = (from b in she.Bill
                                 where b.HomeId == homeId && !b.IsPaid
                                 select new BillModel
                                 {
                                     BillType = b.Type,
                                     Amount = b.Amount,
                                     PaymentDueDate = b.PaymentDueDate
                                 }).ToList();
                    return query;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
