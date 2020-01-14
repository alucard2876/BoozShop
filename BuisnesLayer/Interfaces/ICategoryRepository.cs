using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLayer.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategory(int id);
        IEnumerable<Category> GetAllCategories();
        void AddCategorie(Category category);
    }
}
