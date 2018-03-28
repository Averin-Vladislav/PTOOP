using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    class Train : Vehicle
    {
        public int carriageCount;
        public String tractionType;

        public Train(String model, String color, int madeYear, int _carriageCount, String _tractionType)
            : base(model, color, madeYear)
        {
            this.carriageCount = _carriageCount;
            this.tractionType = _tractionType;
        }
    }
}
