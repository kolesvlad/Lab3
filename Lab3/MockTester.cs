namespace Lab3;

public class MockTester
{
    public List<Restaurant> Restaurants;
    public List<Dish> Dishes;
    public List<Client> Clients;
    public DeliveryManager DeliveryManager;

    public Random Random;

    public MockTester()
    {
        // Створення тестових обʼєктів
        Restaurants = new List<Restaurant>();

        NutritionFacts streetFoodNutritionFacts =
            new NutritionFacts(30, 20, 50, 100, 0, [Vitamin.A, Vitamin.B], 10, 5, 0);
        NutritionFacts japaneseFoodNutritionFacts =
            new NutritionFacts(20, 40, 40, 0, 50, [Vitamin.C, Vitamin.D], 0, 10, 20);
        NutritionFacts italianFoodNutritionFacts =
            new NutritionFacts(30, 30, 40, 50, 20, [Vitamin.D, Vitamin.E], 50, 20, 30);

        Dish dish1 = new StreetDish("Shaurma", "Z kota", 5, streetFoodNutritionFacts);
        Dish dish2 = new StreetDish("Hot Dog", "Z sobaky", 3, streetFoodNutritionFacts);
        Dish dish3 = new StreetDish("Burger", "Z yalovychyny", 6, streetFoodNutritionFacts);
        Dish dish4 = new JapaneseDish("Roly", "Z rysu", 10, japaneseFoodNutritionFacts);
        Dish dish5 = new JapaneseDish("Sushi", "Sche bilshe rysu", 9, japaneseFoodNutritionFacts);
        Dish dish6 = new JapaneseDish("Set", "Bahato vsyoho", 15, japaneseFoodNutritionFacts);
        Dish dish7 = new ItalianDish("Pizza", "Z sousom", 10, italianFoodNutritionFacts);
        Dish dish8 = new ItalianDish("Pasta", "Z makaronamy", 5, italianFoodNutritionFacts);
        Dish dish9 = new ItalianDish("Lazanya", "Z myasom", 8, italianFoodNutritionFacts);

        Dishes = [dish1, dish2, dish3, dish4, dish5, dish6, dish7, dish8, dish9];

        Restaurants.Add(new Restaurant("MacDuck", "vul. Stepana Bandery", 1, 3.0, [Dishes[0], Dishes[1], Dishes[2]]));
        Restaurants.Add(new Restaurant("YaponaMama", "vul. Romana Shuhevycha", 2, 4.0,
            [Dishes[3], Dishes[4], Dishes[5]]));
        Restaurants.Add(new Restaurant("Mama Miya", "vul. Psa Patrona", 3, 5.0, [Dishes[6], Dishes[7], Dishes[8]]));

        Client client1 = new Client("Poroh", "vul. Roshena", 12345, new List<Order>());
        Client client2 = new Client("Zelya", "vul. Kvartalu", 67890, new List<Order>());
        Client client3 = new Client("Lyashko", "vul. Radykalna", 77777, new List<Order>());

        Clients = [client1, client2, client3];

        DeliveryManager = new DeliveryManager();

        Random = new Random();
    }

    public void MockRandomOrder()
    {
        // Отримання випадкових обʼєктів з попередньо створених в конструкторі
        var restaurant = GetRandomRestaurant();
        var dishes = GetRandomDishes(restaurant);
        var client = GetRandomClient();
        
        // Імітація створення замовлення з параметрами
        var order = DeliveryManager.CreateOrder(dishes, restaurant, client);
        
        // Імітація відправки замовлення бізнесом
        DeliveryManager.SendOrder(order);
        
        // Імітації отримання замовлення клієнтом
        DeliveryManager.DeliverOrder(order);
    }

    private Restaurant GetRandomRestaurant()
    {
        return Restaurants[Random.Next(Restaurants.Count)];
    }

    private List<Dish> GetRandomDishes(Restaurant restaurant)
    {
        var excludeIndex = Random.Next(restaurant.Dishes.Count);
        var newDishes = new List<Dish>(restaurant.Dishes);
        newDishes.RemoveAt(excludeIndex);

        return newDishes;
    }

    private Client GetRandomClient()
    {
        return Clients[Random.Next(Clients.Count)];
    }
}