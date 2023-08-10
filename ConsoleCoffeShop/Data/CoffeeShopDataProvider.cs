using ConsoleCoffeShop.Model;

namespace ConsoleCoffeShop.Data;

public class CoffeeShopDataProvider
{
    public IEnumerable<CoffeeShop> LoadShops()
    {
        return new CoffeeShop[]
        {
            new CoffeeShop("Franckfurt", 45),
            new CoffeeShop("Zurich", 39),
            new CoffeeShop("Rome", 25),
            new CoffeeShop("Lyon", 57)
        };
    }
}
