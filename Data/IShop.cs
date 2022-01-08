using System.Collections;
using System.Collections.Generic;
using Data.Memory;

namespace Data
{
    public interface IShop
    {
        public string Name { get; init; }
        
        public string Address { get; init; }
        
        public void Add(Alcohol drink);

        public ICheck Sell(Alcohol drink);

        public IEnumerable<IAlcohol> Drinks { get; }
    }
}