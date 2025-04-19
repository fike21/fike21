public class Ambulance : EmergencyUnit
{
    public Ambulance(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public override bool CanHandle(string incidentType)
    {
        return incidentType == "Medical";
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is treating patients at {incident.Location}.");
    }
}