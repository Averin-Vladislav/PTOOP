using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    class Sailboard : Vehicle
    {
        public String boardСlass;
        public String sailType;

        public Sailboard(String model, String color, int madeYear, String _boardClass, String _sailType)
            : base(model, color, madeYear)
        {
            this.boardСlass = _boardClass;
            this.sailType = _sailType;
        }
    }
}
