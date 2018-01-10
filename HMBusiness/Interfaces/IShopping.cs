using HMModels.Models;

namespace HMBusiness.Interfaces
{
    interface IShopping
    {
        void SaveShoppingItem();
        void UpdateShoppingItem(ShoppingModel shoppingModel);
        ShoppingModel GetShoppingItem(int itemId);
        void DeleteShoppingItem(int itemId);
    }
}
