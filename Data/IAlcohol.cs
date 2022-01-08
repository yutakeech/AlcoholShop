namespace Data
{
    public interface IAlcohol
    {
        public string Producer { get; init; }
        
        public string Name { get; init; }
        
        public string Vintage { get; init; }
        
        public double Price { get; set; }
        
    }
}