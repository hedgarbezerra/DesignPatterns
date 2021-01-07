using DesignPatterns.Builder;
using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TestingClass
    {
        static void Main(string[] args)
        {

            var hb = new HousesBuilder();

            //Builder comum
            var house = hb
                .AddDoor(2)
                .AddGarage(1)
                .AddRoom(3)
                .AddWindow(8)
                .Build();

            Console.WriteLine(house);

            //Builder com facade
            var pb = new PersonBuilder();
            Person person = pb
              .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
              .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);

            Console.WriteLine(person);


            Console.ReadKey();

            //uso de factory method
            var pointFactoryMethod = Point.NewCartesianPoint(1, 4);

            //uso de factory com uma classe interna para segregação
            var innerPointFactory = PointInner.Factory.NewCartesianPoint(1, 5);


        }
    }
}
