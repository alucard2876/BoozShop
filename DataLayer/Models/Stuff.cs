using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Stuff
    {
        public int StuffId { get; set; }
        public string StuffName { get; set; }
        public float StuffLiter { get; set; }
        public string StuffSmallDescription { get; set; }
        public string StuffMainDescription { get; set; }
        public byte[] StuffImg { get; set; }
        public decimal StuffPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

    }
}
