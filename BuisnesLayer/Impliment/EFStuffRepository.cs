using BuisnesLayer.Interfaces;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IStuffRepository = BuisnesLayer.Interfaces.IStuffRepository;

namespace BuisnesLayer.Impliment
{
    public class EFStuffRepository : IStuffRepository
    {
        private readonly ConnectionContext ctx;
        public EFStuffRepository(ConnectionContext context)
        {
            ctx = context;
        }
        public async void AddStuff(Stuff stuff)
        {
            ctx.AllStuff.Add(stuff);
            await ctx.SaveChangesAsync();
        }

        public async void DeleteStuff(int id)
        {
            var stuff = ctx.AllStuff.Where(s => s.StuffId == id).FirstOrDefault();
            if (stuff != null)
            {
                ctx.AllStuff.Remove(stuff);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Stuff>> GetAllStuff()
        {
            return ctx.AllStuff.Include(s => s.Category);
        }

        public async Task<Stuff> GetCurrentStuff(int id)
        {

            return await ctx.AllStuff.Where(s => s.StuffId == id).FirstOrDefaultAsync(); ;
        }

        public async void UpdateStuff(Stuff stuff, int id)
        {
            ctx.AllStuff.Update(stuff);
            await ctx.SaveChangesAsync();
        }
    }
}
