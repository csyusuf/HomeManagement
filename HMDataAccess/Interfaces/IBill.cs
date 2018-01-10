using HMModels.Models;
using System.Collections.Generic;

namespace HMDataAccess.Interfaces
{
    interface IBill
    {
        void SaveBill(BillModel billModel);
        List<BillModel> GetBillNotPaid(int homeId);
    }
}
