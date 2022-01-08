using System.Collections.Generic;
using System.Linq;

namespace Data.Memory
{
    public class Shop : IShop
    {
        // Список со всем алкоголем в магазине
        private IList<IAlcohol> drinks = new List<IAlcohol>();
        public string Name { get; init; }
        public string Address { get; init; }

        public ICheck Sell(Alcohol drink)
        {
            
        }
        
        public IEnumerable<IAlcohol> Drinks
        {
            get => this.drinks;
        }
        
        public void Add(Alcohol drink)
        {
            this.drinks.Append(drink);
        }
    }
}