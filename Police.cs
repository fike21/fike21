public class Police : EmergencyUnit
{
    public Police(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public override bool CanHandle(string incidentType)
    {
        return incidentType == "Crime";
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is responding to crime at {incident.Location}.");
        Console.ForegroundColor = ConsoleColor.Blue;
    }
}