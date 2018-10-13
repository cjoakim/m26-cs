using System;
using Joakimsoftware.M26;

namespace Joakimsoftware.M26.Example {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("M26 Examples Program");

            Distance d = new Distance(26.2);
            double m = d.asMiles();
            double k = d.asKilometers();
            double y = d.asYards();
            Console.WriteLine($"d  - miles: {m}, km: {k}, yds: {y}");

            ElapsedTime et = new ElapsedTime(3, 47, 30);
            double secs = et.secs;
            double hours = et.hours();
            Console.WriteLine($"et - secs: {secs}, hours: {hours}");

            Speed sp = new Speed(d, et);
            double mph = sp.mph();
            double kph = sp.kph();
            double yph = sp.yph();
            double spm = sp.secondsPerMile();
            string ppm = sp.pacePerMile();
            Console.WriteLine($"sp - mph: {mph}, kph: {kph}, yph: {yph}");
            Console.WriteLine($"sp - spm: {spm}, ppm: {ppm}");


        }
    }
}
