using System.Collections;

namespace Lab3;

public class DeliveryManager
{
    public List<Order> PendingOrders;
    public List<Courier> Couriers;

    public Random Random;

    public DeliveryManager()
    {
        Couriers = new List<Courier>();
        Courier courier1 = new Courier("Vasya Bidnenko", "bidnyak@gmail.com", 1.0, Transport.None);
        Courier courier2 = new Courier("Vova Studenchuk", "student@gmail.com", 2.0, Transport.Bicycle);
        Courier courier3 = new Courier("Petya Bahatskyi", "blatnyi@gmail.com", 3.0, Transport.Car);
        Couriers = [courier1, courier2, courier3];
        
        Random = new Random();
    }
    
    public Order CreateOrder(List<Dish> dishes, Restaurant restaurant, Client client)
    {
        var order = new Order(dishes, OrderStatus.Created, restaurant, GetRandomCourier(), client);

        AddOrderToPending(order);

        client.OrderHistory.Add(order);
        
        DisplayOrderStatus(order);

        return order;
    }

    private Courier GetRandomCourier()
    {
        var availableCouriers = GetAvailableCouriers();
        return availableCouriers[Random.Next(availableCouriers.Count)];
    }

    private List<Courier> GetAvailableCouriers()
    {
        var busyCouriers = new List<Courier>();
        try
        {
            busyCouriers = PendingOrders
                .Select(pOrder => pOrder.Courier)
                .ToList();
        }
        catch (ArgumentNullException e)
        {
            // Перехоплення виключення в разі PendingOrder == null
            Console.WriteLine(e.ToString());
        }

        var availableCouriers = Couriers
            .FindAll(courier => !busyCouriers.Contains(courier))
            .ToList();

        return availableCouriers;
    }

    private void AddOrderToPending(Order order)
    {
        try
        {
            PendingOrders.Add(order);
        }
        catch (NullReferenceException e)
        {
            PendingOrders = new List<Order>();
            PendingOrders.Add(order);
            
            Console.WriteLine(e.ToString());
        }
    }
    
    private void DisplayOrderStatus(Order order)
    {
        Console.WriteLine($"{nameof(Order.OrderStatus)}: {order.OrderStatus}");
    }

    public Order SendOrder(Order order)
    {
        order.UpdateOrderStatus(OrderStatus.Sent);
        DisplayOrderStatus(order);

        return order;
    }

    public Order DeliverOrder(Order order)
    {
        order.UpdateOrderStatus(OrderStatus.Delivered);
        DisplayOrderStatus(order);

        return order;
    }
}