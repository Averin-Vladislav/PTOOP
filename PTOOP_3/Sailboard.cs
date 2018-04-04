using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary;

namespace PTOOP_3
{
    [Serializable]
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

        public void Update(String model, String color, int madeYear, String _boardClass, String _sailType)
        {
            base.Update(model, color, madeYear);

            this.boardСlass = _boardClass;
            this.sailType = _sailType;
        }

        public override String GetString()
        {
            return "Sailboard: " + this.model + ", color: " + this.color + ", made year: " + this.madeYear + ", board class: " + this.boardСlass + ", sail type: " + this.sailType + ")";
        }
    }
}
