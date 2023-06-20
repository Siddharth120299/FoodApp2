using FoodApp2.Data.Entities.Foods;
using FoodApp2.Data.Entities.Foods.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp2.Service.Foods
{
    public interface IFoodService
    {
        Task<IList<FoodListingViewModel>> GetAllFoodsAsync();

        Task<IList<Food>> GetAllFoodsByFoodTypeIdAsync(long foodTypeId);

        Task<Food> GetFoodByIdAsync(long id);
    }
}