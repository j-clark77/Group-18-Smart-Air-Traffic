using System;

namespace SkyStream
{
    public class RunwayLights
    {
        public bool LightsActive;
        public int IlluminationLevel;

        public RunwayLights()
        {
        }

        public void ToggleLights()
        {
            LightsActive = !LightsActive;
            Console.WriteLine("Runway lights toggled. Current state: " + LightsActive);
        }
    }
}