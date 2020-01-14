using BuisnesLayer.Interfaces;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLayer.Impliment
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ConnectionContext ctx;
        public EFCategoryRepository(ConnectionContext context)
        {
            ctx = context;
        }
        public async void AddCategorie(Category category)
        {
            if (category != null)
            {
                ctx.Categories.Add(category);
                await ctx.SaveChangesAsync();
            }
        }



        public IEnumerable<Category> GetAllCategories()
        {
            return ctx.Categories.Include(c => c.StuffInCategory);
        }

        public async Task<Category> GetCategory(int id)
        {
            return await ctx.Categories.Where(c => c.CategoryId == id).FirstOrDefaultAsync();
        }
    }
}
