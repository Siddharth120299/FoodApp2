using FoodApp2.Data.Entities.Foods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp2.Service.Foods
{
    public interface IFoodTypeService
    {
        Task<IList<FoodType>> GetAvailableFoodTypesAsync();

        Task<FoodType> GetFoodTypeByIdAsync(long id);
    }
}