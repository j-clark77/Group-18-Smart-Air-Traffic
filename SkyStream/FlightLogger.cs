using System;
using System.Collections.Generic;

namespace SkyStream
{
    public class FlightLogger
    {
        public static List<string> AirspaceHistory;

        public FlightLogger()
        {
            if (AirspaceHistory == null)
            {
                AirspaceHistory = new List<string>();
            }
        }

        public void LogFlight(string flightNote)
        {
            AirspaceHistory.Add(flightNote);
        }

        public void PrintFlightRecord()
        {
            Console.WriteLine("\n--- Secure Airspace History ---");
            foreach (string note in AirspaceHistory)
            {
                Console.WriteLine(note);
            }
        }
    }
}