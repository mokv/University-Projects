using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingToSunWithSoundSpeed
{
    //149.6 million km = Distance between Earth and the Sun
    //1,192 km/h = Speed of sound
    class TravelingToSunWithSoundSpeed
    {
        static void Main(string[] args)
        {
            double sunEarthDistance = 149600000;
            double soundSpeed = 1192;
            double timeInHours = sunEarthDistance / soundSpeed;
            double timeInDays = timeInHours / 24;
            double timeInYears = timeInDays / 365;
            double timeInYearsLeftover = timeInDays % 365;
            Console.WriteLine($"The time needed to travel from Earth to the Sun is {Math.Round(timeInHours)} hours, or {Math.Round(timeInYears)} years and {Math.Round(timeInYearsLeftover)} days.");
        }
    }
}
