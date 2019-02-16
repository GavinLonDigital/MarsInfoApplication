using System;
using System.Configuration;


namespace MarsInfoApplication
{
    public class Constants
    {
        public const int SpeedOfLight = 300000;
    }

    public class Mars
    {
        
        public readonly int DistanceToMars = 0;

        public Mars()
        {
            DistanceToMars = Convert.ToInt32(ConfigurationManager.AppSettings["DistanceToMars"]);
        }

        public int GetInfoTravelTime()
        {
            return DistanceToMars / Constants.SpeedOfLight;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Mars mars = new Mars();

            Console.WriteLine($"Information travel time is approximately {mars.GetInfoTravelTime()} seconds from Mars to Earth.");
            Console.ReadKey();
        }
    }
}
