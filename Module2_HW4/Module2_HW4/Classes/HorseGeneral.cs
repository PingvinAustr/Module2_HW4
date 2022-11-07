using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public class HorseGeneral : Mammal
    {
       public HorseGeneral(string name, int weight, int speed, MovementType.MovementOption movOption, int horseshoeSize)
            : base(name, weight, speed, movOption)
        {
            HorseshoeSize = horseshoeSize;
        }

       public int HorseshoeSize { get; set; }

       public override void SimulateLife()
       {
            Console.WriteLine("HorseGeneral is living");
       }
    }
}
