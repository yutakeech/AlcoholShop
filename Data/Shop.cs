using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class Shop : IShop
    {
        Shop(IData<Alcohol> alcoholData, IData<Check> checkData)
        {
            AlcoholData = alcoholData;
            CheckData = checkData;
        }

        protected IData<Alcohol> AlcoholData;
        protected IData<Check> CheckData;
        
        // Список со всем алкоголем в магазине
        private IList<IAlcohol> drinks = new List<IAlcohol>();
        public string Name { get; init; }
        public string Address { get; init; }

        public ICheck Sell(Alcohol drink)
        {
            throw new Exception("Не реализовал, получается");
        }
        
        public IEnumerable<IAlcohol> Drinks
        {
            get => this.drinks;
        }

        /*public void Add(IData<Alcohol> AlcoholData, IData<Check> CheckData)
        {
           
        }
        
        public void Remove(IData<Alcohol> AlcoholData, IData<Check> CheckData)
        {
            // Необходимо добавить весь алкоголь из списка CheckData
        }
        
        public void All(IData<Alcohol> AlcoholData, IData<Check> CheckData)
        {
            // Необходимо добавить весь алкоголь из списка CheckData
        }*/
        
        public void Add(Alcohol drink)
        {
            this.drinks.Append(drink);
        }
    }
}