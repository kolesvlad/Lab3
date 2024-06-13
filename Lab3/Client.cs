namespace Lab3;

public class Client
{
    public string Name;
    public string Address;
    public int ContactNumber;
    public List<Order> OrderHistory;

    public Client(string name, string address, int contactNumber, List<Order> orderHistory)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
        OrderHistory = orderHistory;
    }
}