using System.Collections.Generic;
using Data;
using Data.Memory;

IShop CreateStore(string name, string address)
{
    //return new Shop {Name = name, Address = address};
}

IAlcohol CreateDrink(string producer, double price, string vintage, string name)
{
    return new Alcohol {Producer = producer, Price = price, Vintage = vintage, Name = name};
}

ICheck CreateCheck()
{
    return new Check {};
}

void Main()
{
    var store = CreateStore("Stakan", "Nevskogo, 14");
    var alcohole = CreateDrink("Italy", 1000, "Для коктелей", "Martini");
}

namespace AlcoholStore
{
    
}