using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
        public MovementType.MovementOption MovementType { get; set; }
    }
}
