using System;

namespace SkyStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SkyStream Tower OS (Legacy Build 0.1) ===");

            TowerSecurity security = new TowerSecurity("Controller1", "Flight123");

            Console.Write("Enter Controller Profile: ");
            string profile = Console.ReadLine();
            Console.Write("Enter Access Code: ");
            string code = Console.ReadLine();

            bool isAuthorised = security.AuthoriseTerminal(profile, code);

            if (isAuthorised)
            {
                Console.WriteLine("Radar Terminal Unlocked.");
            }
            else
            {
                Console.WriteLine("Access Denied. Terminal Locked.");
            }

            LoadRadarDashboard();
        }

        static void LoadRadarDashboard()
        {
            AltitudeSensor sensor = new AltitudeSensor("Radar_North");
            FlightLogger logger = new FlightLogger();

            while (true)
            {
                Console.WriteLine("\n1. Record Flight Altitude");
                Console.WriteLine("2. View Average Altitude");
                Console.WriteLine("3. View Airspace Logs");
                Console.Write("Select Option: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Altitude (FT): ");
                    int altitude = int.Parse(Console.ReadLine());
                    sensor.ReadTelemetry(altitude);
                    logger.LogFlight("Altitude tracked: " + altitude + " FT");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Average Altitude: " + sensor.CalculateAverageAltitude() + " FT");
                }
                else if (choice == 3)
                {
                    logger.PrintFlightRecord();
                }
                else
                {
                    Console.WriteLine("Invalid terminal choice.");
                }
            }
        }
    }
}