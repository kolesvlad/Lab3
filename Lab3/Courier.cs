namespace Lab3;

public class Courier
{
    public string Name;
    public string LastName;
    public string Contacts;
    public double Rating;
    public Transport Transport;

    public Courier(string name,string contacts, double rating, Transport transport)
    {
        Name = ExtractName(name);
        LastName = ExtractLastName(name);
        Contacts = contacts;
        Rating = rating;
        Transport = transport;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(LastName)}: {LastName}, {nameof(Contacts)}: {Contacts}, {nameof(Rating)}: {Rating}, {nameof(Transport)}: {Transport}";
    }

    private string ExtractName(string name)
    {
        return name.Split(" ")[0];
    }
    
    private string ExtractLastName(string name)
    {
        return name.Split(" ")[1];
    }
}

public enum Transport
{
    Bicycle,
    Car,
    None
}