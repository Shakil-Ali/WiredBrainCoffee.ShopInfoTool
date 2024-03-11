using WiredBrainCoffee.ShopInfoTool.Model;

namespace WiredBrainCoffee.ShopInfoTool.Data;

public class CoffeeShopDataProvider
{
    public IEnumerable<CoffeeShop> LoadShops()
    {
        return new CoffeeShop[]
        {
            new CoffeeShop("London", 45),
            new CoffeeShop("Sylhet", 39),
            new CoffeeShop("Medina", 28),
            new CoffeeShop("Dubai", 38)
        };
    }
}
