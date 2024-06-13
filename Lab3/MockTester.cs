namespace Lab3;

public class MockTester
{
    public List<Restaurant> Restaurants;
    public List<Client> Clients;
    public DeliveryManager DeliveryManager;

    public Random Random;

    public MockTester()
    {
        Restaurants = new List<Restaurant>();

        Random = new Random();

    }

    public void CreateRandomOrder()
    {
        var restaurant = GetRandomRestaurant();
        
    }

    private Restaurant GetRandomRestaurant()
    {
        return Restaurants[Random.Next(Restaurants.Count)];
    }
}