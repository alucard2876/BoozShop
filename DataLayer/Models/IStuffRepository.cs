using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IStuffRepository
    {
        Task<IEnumerable<Stuff>> GetAllStuff();
        Task<Stuff> GetCurrentStuff(int id);
        void AddStuff(Stuff stuff);
        void UpdateStuff(Stuff stuff, int id);
        void DeleteStuff(int id);
    }
}
