using Lab3;

class Program
{
    static void Main()
    {
        var rest = new Restaurant("name1", "address1", 1, 5.0, new List<Dish>());
        Console.WriteLine(rest.ToString());
    }
}