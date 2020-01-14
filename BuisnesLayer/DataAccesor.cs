using BuisnesLayer.Interfaces;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnesLayer
{
    public class DataAccesor
    {
        public IStuffRepository StuffRepo { get; private set; }
        public ICategoryRepository CategoryRepo { get; private set; }

        public DataAccesor(IStuffRepository stuffRepo, ICategoryRepository categoryRepo)
        {
            StuffRepo = stuffRepo;
            CategoryRepo = categoryRepo;
        }

    }
}
