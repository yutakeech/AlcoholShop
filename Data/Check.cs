using System;
using System.Collections.Generic;

namespace Data
{
    public class Check : ICheck
    {
        public IAlcohol Item { get; set; }
        public IShop Shop { get; set; }
        public DateTime DateTime { get; set; }
    }
}