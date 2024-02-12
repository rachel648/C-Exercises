using System;

class SpeedingTicket
{
    static void Main(string[] args)
    {
        // Prompt the policeman to enter the vehicle's speed and the speed limit
        Console.WriteLine("Enter the vehicle's speed (in kph):");
        int vehicleSpeed = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the speed limit (in kph):");
        int speedLimit = Convert.ToInt32(Console.ReadLine());

        // Calculate the excess speed
        int excessSpeed = vehicleSpeed - speedLimit;

        // Calculate the fine based on the excess speed
        int fine;
        if (excessSpeed < 30)
        {
            fine = 2500;
        }
        else
        {
            fine = 4000;
        }

        // Output the results
        Console.WriteLine("\nVehicle Speed: " + vehicleSpeed + " kph");
        Console.WriteLine("Speed Limit: " + speedLimit + " kph");
        Console.WriteLine("Excess Speed: " + excessSpeed + " kph");
        Console.WriteLine("Fine Levied: Kshs " + fine);
    }
}
