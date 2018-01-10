using HMBusiness.Interfaces;
using HMDataAccess;
using HMModels.Models;
using System;

namespace HMBusiness
{
    public class ShoppingBusiness : IShopping
    {
        private ShoppingModel shoppingModel;

        public ShoppingBusiness(string itemName, int userId, int homeId) {
            shoppingModel = new ShoppingModel();
            shoppingModel.ItemName = itemName;
            shoppingModel.ResponsibleUserId = userId;
            shoppingModel.HomeId = homeId;
        }

        public void DeleteShoppingItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public ShoppingModel GetShoppingItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public void SaveShoppingItem()
        {
            ShoppingOperations shoppingOps = new ShoppingOperations();
            shoppingOps.AddShoppingItem(shoppingModel);
        }

        public void UpdateShoppingItem(ShoppingModel shoppingModel)
        {
            throw new NotImplementedException();
        }
    }
}
