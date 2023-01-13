using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public class Pack
    {
        private Mammal[] _mammals = new Mammal[100];

        private int _totalWeight;
        public Pack(Mammal[] mammals)
        {
            _mammals = mammals;
            _totalWeight = 0;
            foreach (Mammal mammal in mammals)
            {
                _totalWeight += mammal.Weight;
            }
        }

        public Mammal[] ReturnPackMammals()
        {
            return _mammals;
        }

        public int ReturnPackWeight()
        {
            return _totalWeight;
        }

        public void SetPackMammals(Mammal[] mammals)
        {
            _mammals = mammals;
        }
    }
}
