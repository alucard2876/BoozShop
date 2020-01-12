using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Models
{
    public class EFCategorieRepository : ICategoryRepository
    {
        private readonly ConnectionContext ctx;
        public EFCategorieRepository(ConnectionContext context)
        {
            ctx = context;
        }
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
            return ctx.Categories.Include(c => c.StuffInCategory);
        }

        public Category GetCategory(int id)
        {
            var category = ctx.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            return category;
        }
    }
}
