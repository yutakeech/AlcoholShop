using System;
using System.Collections.Generic;

namespace Data.Memory
{
    public class Check : ICheck
    {
        public double Price { get; set; }
        public IEnumerable<IAlcohol> Drinks { get; set; }
        public DateTime Date { get; set; }
    }
}