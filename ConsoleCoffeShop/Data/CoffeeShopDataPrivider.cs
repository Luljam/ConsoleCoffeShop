using ConsoleCoffeShop.Model;

namespace ConsoleCoffeShop.Data;

public class CoffeeShopDataPrivider
{
    public IEnumerable<CoffeeShop> LoadShops()
    {
        return new CoffeeShop[]
        {
            new CoffeeShop("Franckfurt", 45),
            new CoffeeShop("Zurich", 39),
            new CoffeeShop("Rome", 25)
        };
    }
}
