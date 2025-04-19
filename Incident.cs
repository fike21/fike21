public class Incident
{
    public string Type { get; set; }
    public string Location { get; set; }

    public Incident(string type, string location)
    {
        Type = type;
        Location = location;
    }
}