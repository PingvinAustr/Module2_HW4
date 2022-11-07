using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    internal static class PackExtension
    {
        public static Mammal FindPackSlowestAnimal(this Pack order, Mammal[] mammals)
        {
            int minSpeed = int.MaxValue;
            Mammal slowestMammal = null;

            foreach (Mammal mammalLoc in mammals)
            {
                if (mammalLoc.Speed < minSpeed)
                {
                    minSpeed = mammalLoc.Speed;
                    slowestMammal = mammalLoc;
                }
            }

            return slowestMammal;
        }
    }
}
