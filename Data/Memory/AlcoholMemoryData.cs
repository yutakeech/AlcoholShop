using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data.Memory
{
    public class AlcoholMemoryData : IData<Alcohol>
    {
        AlcoholMemoryData(List<Alcohol> items, Alcohol item)
        {
            // То, что есть у магазина
            this.items = items;
            // То, что выбрал покупатель
            this.item = item;
        }
        
        private List<Alcohol> items;
        private Alcohol item;
        
        public void Add(Alcohol item)
        {
            ((ICollection<Alcohol>)items).Add(item);
        }
        
        public bool Remove(Alcohol item)
        {
            return ((ICollection<Alcohol>)items).Remove(item);
        }
        
        public IEnumerator<Alcohol> GetEnumerator()
        {
            return ((ICollection<Alcohol>)items).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<Alcohol>)items).GetEnumerator();
        }
    }
}