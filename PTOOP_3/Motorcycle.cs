using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    class Motorcycle : Vehicle
    {
        String type;
        bool buggy;

        public Motorcycle(String model, String color, int madeYear, String _type, bool _buggy)
            : base(model, color, madeYear)
        {
            this.type = _type;
            this.buggy = _buggy;
        }

        public void Update(String model, String color, int madeYear, String _type, bool _buggy)
        {
            base.Update(model, color, madeYear);

            this.type = _type;
            this.buggy = _buggy;
        }
    }
}
