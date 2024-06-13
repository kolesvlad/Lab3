namespace Lab3;

public class Order
{
    public List<Dish> Dishes;
    public long TotalPrice;
    public int OrderStatus;
    public Restaurant Restaurant;
    public Courier Courier;
    public Client Client;

    public Order(List<Dish> dishes, long totalPrice, int orderStatus, Restaurant restaurant, Courier courier, Client client)
    {
        Dishes = dishes;
        TotalPrice = totalPrice;
        OrderStatus = orderStatus;
        Restaurant = restaurant;
        Courier = courier;
        Client = client;
    }

    public void UpdateOrderStatus(int newOrderStatus)
    {
        OrderStatus = newOrderStatus;
    }
}