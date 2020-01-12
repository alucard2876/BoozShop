using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class EFCategorieRepository : ICategoryRepository
    {
        public void AddCategorie(Category category)
        {
            throw new NotImplementedException();
        }

        public void AddStuffToCategorie(Stuff stuff, int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
