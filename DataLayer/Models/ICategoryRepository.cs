using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);
        IEnumerable<Category> GetAllCategories();
        void AddCategorie(Category category);
        void AddStuffToCategorie(Stuff stuff, int categoryId);
    }
}
