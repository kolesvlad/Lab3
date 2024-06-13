namespace Lab3;

public class Order
{
    public List<Dish> Dishes;
    public long TotalPrice;
    public OrderStatus OrderStatus { get; private set; }
    public Restaurant Restaurant;
    public Courier Courier;
    public Client Client;

    public Order(List<Dish> dishes, OrderStatus orderStatus, Restaurant restaurant, Courier courier, Client client)
    {
        Dishes = dishes;
        TotalPrice = CalculateTotalPrice(dishes);
        OrderStatus = orderStatus;
        Restaurant = restaurant;
        Courier = courier;
        Client = client;
    }

    private long CalculateTotalPrice(List<Dish> dishes)
    {
        var prices = dishes.Select(dish => dish.Price).ToList();
        var totalPrice = 0L;
        foreach (var price in prices)
        {
            totalPrice += price;
        }

        return totalPrice;
    }

    public void UpdateOrderStatus(OrderStatus newOrderStatus)
    {
        OrderStatus = newOrderStatus;
    }
}

public enum OrderStatus
{
    Created, Sent, Delivered
}