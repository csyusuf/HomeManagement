using HMData;
using HMDataAccess.Interfaces;
using HMModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HMDataAccess
{
    public class FoodOperations : IFood
    {
        public FoodOperations()
        {

        }

        public void AddFood(FoodModel foodModel)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var food = she.Food.Add(new Food
                    {
                        Name = foodModel.FoodName,
                        BuyDate = foodModel.BuyDate,
                        BestBeforeDate = foodModel.BestBeforeDate,
                        HomeId = foodModel.HomeId,
                        ConsumedDate = foodModel.ConsumedDate
                    });
                    she.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<FoodModel> GetConsumedFood(int homeId)
        {
            using (SweetHomeEntities she = new SweetHomeEntities())
            {
                try
                {
                    var query = (from f in she.Food
                                 where f.HomeId == homeId && (f.ConsumedDate != null)
                                 select new FoodModel
                                 {
                                     BuyDate = f.BuyDate,
                                     FoodName = f.Name,
                                     ConsumedDate = (DateTime) f.ConsumedDate
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
