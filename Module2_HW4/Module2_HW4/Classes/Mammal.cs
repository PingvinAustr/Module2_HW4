using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public class Mammal : IAnimal
    {
        public Mammal(string name, int weight, int speed, MovementType.MovementOption movOption)
        {
            Name = name;
            Weight = weight;
            Speed = speed;
            MovementType = movOption;
        }

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
        public MovementType.MovementOption MovementType { get; set; }

        public virtual void SimulateLife()
        {
            Console.WriteLine("Mammal is living");
        }
    }
}
