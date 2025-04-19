public abstract class EmergencyUnit
{
    public string Name { get; set; } = "Unnamed Unit";
    public int Speed { get; set; } = 50; // Default speed
public int ResponseTime => new Random().Next(Speed, Speed*2); // Varying response times

    protected EmergencyUnit() { }

    protected EmergencyUnit(string name, int speed)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Speed = speed;
    }

    public abstract bool CanHandle(string incidentType);
public bool IsAvailable { get; set; } = true; // Add to EmergencyUnit
    public abstract void RespondToIncident(Incident incident);
}