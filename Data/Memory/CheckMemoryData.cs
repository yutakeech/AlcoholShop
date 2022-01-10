using System.Collections;
using System.Collections.Generic;

namespace Data.Memory
{
    public class CheckMemoryData : IData<Check>
    {
        CheckMemoryData(List<Check> checks, Check check)
        {
            // Список всех чеков
            this.checks = checks;
            // Текущий чек
            this.check = check;
        }
        
        private List<Check> checks;
        private Check check;
        
        public void Add(Check item)
        {
            ((ICollection<Check>)checks).Add(check);
        }
        
        public bool Remove(Check item)
        {
            return ((ICollection<Check>)checks).Remove(check);
        }
        
        public IEnumerator<Check> GetEnumerator()
        {
            return ((ICollection<Check>)checks).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<Check>)checks).GetEnumerator();
        }
    }
}