using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize emergency units with proper null safety
        var units = new EmergencyUnit[]
        {
            new Police("Police Unit 1", 60),
            new Firefighter("Firefighter Unit 1", 50),
            new Ambulance("Ambulance Unit 1", 70)
        };

        // Incident data
        string[] incidentTypes = { "Crime", "Fire", "Medical" };
        string[] locations = { "Downtown", "City Hall", "Residential Area", "Industrial Zone", "Shopping Mall" };

        var random = new Random();
        int score = 0;

        Console.WriteLine("=== EMERGENCY RESPONSE SIMULATION ===");
        
        // Game loop for 5 rounds
        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine($"\n-Turn {round} ---");
            
            // Generate random incident
            var incident = new Incident(
                incidentTypes[random.Next(incidentTypes.Length)],
                locations[random.Next(locations.Length)]
            );
            
            Console.WriteLine($"Incident: {incident.Type} at {incident.Location}");

            // Find first unit that can handle this incident
            var respondingUnit = units.FirstOrDefault(unit => unit.CanHandle(incident.Type));

            // Handle response
            if (respondingUnit != null)
            {
                respondingUnit.RespondToIncident(incident);
                score += 10;
                Console.WriteLine($"+10 points (Handled by {respondingUnit.Name})");
            }
            else
            {
                Console.WriteLine("No available unit can handle this incident!");
                score -= 5;
                Console.WriteLine("-5 points");
            }

            Console.WriteLine($"Current Score: {score}");
        }

        // Final results
        Console.WriteLine("\n=== SIMULATION COMPLETE ===");
        Console.WriteLine($"Final Score: {score}");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}