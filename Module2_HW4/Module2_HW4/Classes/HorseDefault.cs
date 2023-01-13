using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public class HorseDefault : HorseGeneral
    {
        public HorseDefault(string name, int weight, int speed, MovementType.MovementOption movOption, int horseshoeSize, bool isDomestic)
            : base(name, weight, speed, movOption, horseshoeSize)
        {
            IsDomestic = isDomestic;
        }

        public bool IsDomestic { get; set; }

        public override void SimulateLife()
        {
            Console.WriteLine("HorseDefault is living");
        }
    }
}
