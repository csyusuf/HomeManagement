using HMBusiness.Interfaces;
using HMDataAccess;
using HMModels.Models;
using System;
using System.Collections.Generic;

namespace HMBusiness
{
    public class FoodBusiness : Reminder,IFood
    {
        private FoodModel foodModel;
        public FoodBusiness()
        { }
        public FoodBusiness(string foodName, DateTime buyDate, DateTime bestBeforeDate, int homeId )
        {
            foodModel = new FoodModel {
                FoodName = foodName,
                BuyDate = buyDate,
                BestBeforeDate = bestBeforeDate,
                HomeId = homeId,
                ConsumedDate = DateTime.Now
            };
        }

        public void DeleteFood(int foodId)
        {
            throw new NotImplementedException();
        }

        public void GetFood(int foodId)
        {
            throw new NotImplementedException();
        }

        public List<FoodModel> GetConsumedFood(int homeId)
        {
            FoodOperations foodOps = new FoodOperations();
            return foodOps.GetConsumedFood(homeId);
        }

        public List<FoodModel> GetFoodList(int homeId)
        {
            throw new NotImplementedException();
        }

        public void SaveFood()
        {
            FoodOperations foodOps = new FoodOperations();
            foodOps.AddFood(foodModel);
        }
        
        public void UpdateFood(FoodModel food)
        {
            throw new NotImplementedException();
        }

        public override List<object> GetRemindedThings(int homeId)
        {
            List<FoodModel> consumedFood = GetConsumedFood(homeId);
            List<object> shouldRemindedFoods = new List<object>();
            foreach (var item in consumedFood)
            {
                shouldRemindedFoods.Add(item);
            }
            return shouldRemindedFoods;
        }
    }
}
