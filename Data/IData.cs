using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public interface IData<T> : IEnumerable<T>
    {
        public void Add(T item);
        public bool Remove(T item);
    };
    
}