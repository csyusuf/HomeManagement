using HMModels.Models;
using System.Collections.Generic;

namespace HMBusiness.Interfaces
{
    interface IBill
    {
        void SaveBill();
        void UpdateBill();
        void DeleteBill(int id);
        void GetBill(int id);
        List<BillModel> GetUnPaidBills(int homeId);
    }
}
