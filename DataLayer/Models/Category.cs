using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int StuffId { get; set; }
        public ICollection<Stuff> StuffInCategory { get; set; }
    }
}
