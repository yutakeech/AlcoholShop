using System.Collections.Generic;
using Data;
using Data.Memory;

IStore CreateStore(string name, string address)
{
    return new Store {Name = name, Address = address};
}

IAlcohol CreateDrink(string producer, double price, string description)
{
    return new Alcohol {Producer = producer, Price = price, Description = description};
}

ICheck CreateCheck()
{
    return new Check {};
}

void Main()
{
    var store = CreateStore("Stakan", "Nevskogo, 14");
    var alcohole = CreateDrink("Martini", 1000, "Для коктелей");
}

namespace AlcoholStore
{
    
}