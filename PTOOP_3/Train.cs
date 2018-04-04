using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary;

namespace PTOOP_3
{
    [Serializable]
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

        public void Update(String model, String color, int madeYear, int _carriageCount, String _tractionType)
        {
            base.Update(model, color, madeYear);

            this.carriageCount = _carriageCount;
            this.tractionType = _tractionType;
        }

        public override String GetString()
        {
            return "Train(model: " + this.model + ", color: " + this.color + ", made year: " + madeYear + ", carriage count: " + this.carriageCount + ", traction type: " + this.tractionType + ")";
        }
    }
}
