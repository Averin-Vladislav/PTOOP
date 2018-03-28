using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    [Serializable]
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

        public void Update(String model, String color, int madeYear, int _wheelCount, bool _isSport)
        {
            base.Update(model, color, madeYear);

            this.wheelCount = _wheelCount;
            this.isSport = _isSport;
        }

        public override String GetString()
        {
            return "Bicycle(model: " + this.model + ", color: " + this.color + ", made year: " + this.madeYear + ", wheel count: " + this.wheelCount + ", is sport: " + this.isSport +")";
        }
    }
}
