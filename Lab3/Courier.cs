namespace Lab3;

public class Courier
{
    public string Name;
    public string Contacts;
    public double Rating;
    public Transport Transport;

    public Courier(string name, string contacts, double rating, Transport transport)
    {
        Name = name;
        Contacts = contacts;
        Rating = rating;
        Transport = transport;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Contacts)}: {Contacts}, {nameof(Rating)}: {Rating}, {nameof(Transport)}: {Transport}";
    }
}

public enum Transport
{
    Bicycle,
    Car,
    None
}