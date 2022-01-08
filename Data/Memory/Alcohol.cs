using System.Xml;

namespace Data.Memory
{
    public class Alcohol : IAlcohol
    {
        #region IAlcohol implementation
        public string Producer { get; init; }
        
        public string Name { get; init; }
        public double Price { get; set; }
        
        public string Vintage { get; init; }
        #endregion
    }
}