using System.Collections;
using System.Collections.Generic;

namespace Data.Memory
{
    public class ShopMemoryData : IData<Shop>
    {
        ShopMemoryData(List<Shop> shops, Shop shop)
        {
            // То, что есть у магазина
            this.shops = shops;
            // То, что выбрал покупатель
            this.shop = shop;
        }
        
        private List<Shop> shops;
        private Shop shop;
        
        public void Add(Shop item)
        {
            ((ICollection<Shop>)shops).Add(shop);
        }
        
        public bool Remove(Shop item)
        {
            return ((ICollection<Shop>)shops).Remove(shop);
        }
        
        public IEnumerator<Shop> GetEnumerator()
        {
            return ((ICollection<Shop>)shops).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<Shop>)shops).GetEnumerator();
        }
    }
}