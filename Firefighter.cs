public class Firefighter : EmergencyUnit
{
    public Firefighter(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public override bool CanHandle(string incidentType)
    {
        return incidentType == "Fire";
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is putting out fire at {incident.Location}.");
        Console.ForegroundColor = ConsoleColor.Red;
    }
}