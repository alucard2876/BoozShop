using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IStuffRepository
    {
        IEnumerable<Stuff> GetAllStuff();
        Stuff GetCurrentStuff(int id);
        void AddStuff(Stuff stuff);
        void UpdateStuff(Stuff stuff, int id);
        void DeleteStuff(int id);
    }
}
