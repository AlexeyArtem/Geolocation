using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestGeolocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Geopoint point1 = new Geopoint("Москва", "Ленина", 37);
            Geopoint point2 = new Geopoint("Брянск", "Ленина", 37);

            double distance = point1.GetDistanceTo(point2) / 1000;

            Console.WriteLine("Дистанция (км) = " + distance);

            Console.Read();
        }
    }
}
