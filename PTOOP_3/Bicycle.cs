using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    class Bicycle : Vehicle
    {
        public int wheelCount;
        public bool isSport;

        public Bicycle(String model, String color, int madeYear, int _wheelCount, bool _isSport)
            : base(model, color, madeYear)
        {
            this.wheelCount = _wheelCount;
            this.isSport = _isSport;
        }
    }
}
