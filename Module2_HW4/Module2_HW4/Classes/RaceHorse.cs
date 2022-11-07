using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    internal class RaceHorse : HorseDefault
    {
        public RaceHorse(string name, int weight, int speed, MovementType.MovementOption movOption, int horseshoeSize, bool isDomestic)
            : base(name, weight, speed, movOption, horseshoeSize, isDomestic)
        {
        }

        public override void SimulateLife()
        {
            Console.WriteLine("RaceHorse is living");
        }

        public void SimulateRace()
        {
            Console.WriteLine("RaceHorse is taking part in race...");
        }
    }
}
