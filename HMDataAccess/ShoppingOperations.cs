using HMData;
using HMDataAccess.Interfaces;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDataAccess
{
    public class ShoppingOperations : IShopping
    {
        public ShoppingOperations()
        { }

        public void AddShoppingItem(ShoppingModel shoppingModel)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    she.Shopping.Add(new Shopping
                    {
                        Name = shoppingModel.ItemName,
                        ResponsibleUserId = shoppingModel.ResponsibleUserId,
                        HomeId = shoppingModel.HomeId
                    });

                    she.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
