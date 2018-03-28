using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    [Serializable]
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

        public override String GetString()
        {
            return "Motorcycle(model: " + this.model + ", color: " + this.color + ", made year: " + this.madeYear + ", type: " + this.type + ", is buggy: " + this.buggy + ")";
        }
    }
}
