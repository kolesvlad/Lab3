namespace Lab3;

public class Restaurant
{
    public string Name;
    public string Address;
    public int Type;
    public double Rating;
    public List<Dish> Dishes;

    public Restaurant(string name, string address, int type, double rating, List<Dish> dishes)
    {
        Name = name;
        Address = address;
        Type = type;
        Rating = rating;
        Dishes = dishes;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}, {nameof(Type)}: {Type}, {nameof(Rating)}: {Rating}, {nameof(Dishes)}: {Dishes}";
    }
}