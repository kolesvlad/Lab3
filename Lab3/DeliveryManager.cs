using System.Collections;

namespace Lab3;

public class DeliveryManager
{
    
    
    public List<Order> PendingOrders;
    public List<Courier> Couriers;
    
    public void processOrder(Order order)
    {
        
        
    }

    private List<Courier> GetAvailableCouriers(Order order)
    {
        var busyCouriers = PendingOrders
            .Select(pOrder => pOrder.Courier)
            .ToList();
        var availableCouriers = Couriers
            .FindAll(courier => !busyCouriers.Contains(courier))
            .ToList();

        return availableCouriers;
    }
    

    private void displayOrderStatus(Order order)
    {
        Console.WriteLine($"{nameof(Order.OrderStatus)}: {order.OrderStatus}");
    }
}