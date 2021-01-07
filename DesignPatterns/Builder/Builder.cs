    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class HousesBuilder
    {
        private House house = new House();

        public HousesBuilder()
        {

        }

        public HousesBuilder(string name)
        {
            house.Name = name;
        }

        public HousesBuilder AddDoor(int count)
        {
            house.Doors += count;
            return this;
        }
        public HousesBuilder AddWindow(int count)
        {
            house.Windows += count;
            return this;
        }
        public HousesBuilder AddRoom(int count)
        {
            house.Rooms += count;
            return this;
        }
        public HousesBuilder AddGarage(int count)
        {
            house.Garages += count;
            return this;
        }
        public HousesBuilder AddGarden()
        {
            house.HasGarden = true;
            return this;
        }

        public House Build()
        {
            return house;
        }

        public static implicit operator House (HousesBuilder hb)
        {
            return hb.house;
        }

        public void Clear()
        {
            house = new House();
        }
    }

    public class House
    {
        public string Name { get; set; }
        public int Doors { get; set; }
        public int Rooms { get; set; }
        public int Windows { get; set; }
        public int Garages { get; set; }
        public bool HasGarden { get; set; }

        public override string ToString()
        {
            var hasGardenTxt = HasGarden ? "tem um belo jardim." : "não tem jardim.";
            return $"A casa{ this.Name } tem {Doors} portas, {Rooms} quartos, {Windows} janelas, {Garages} garagens e {hasGardenTxt}";

        }
    }
}
