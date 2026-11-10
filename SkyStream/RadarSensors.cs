using System;

namespace SkyStream
{
    public class SensorNode
    {
        public string RadarID;
        public bool IsOnline;

        public SensorNode(string radarID)
        {
            RadarID = radarID;
            IsOnline = true;
        }

        public void ReadTelemetry()
        {
            Console.WriteLine("Reading generic airspace telemetry...");
        }
    }

    public class AltitudeSensor : SensorNode
    {
        public int CurrentAltitude;
        public int ReadingCount;
        public int TotalAltitude;

        public AltitudeSensor(string radarID) : base(radarID)
        {
            CurrentAltitude = 0;
            ReadingCount = 0;
            TotalAltitude = 0;
        }

        public new void ReadTelemetry(int altitudeFt)
        {
            CurrentAltitude = altitudeFt;
            ReadingCount++;
            TotalAltitude += altitudeFt;
        }

        public double CalculateAverageAltitude()
        {
            if (ReadingCount == 0) return 0;

            return TotalAltitude / ReadingCount;
        }
    }
}