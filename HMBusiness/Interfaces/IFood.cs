using HMModels.Models;
using System.Collections.Generic;

namespace HMBusiness.Interfaces
{
    interface IFood
    {
        void SaveFood();
        void UpdateFood(FoodModel food);
        void DeleteFood(int foodId);
        void GetFood(int foodId);
        List<FoodModel> GetFoodList(int homeId);
    }
}
