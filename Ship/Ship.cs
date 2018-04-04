using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary;
using LibraryInterface;

namespace Ship
{
    public class ShipBuilder : LibraryInterface.LibraryInterface
    {
        public Vehicle GetObject()
        {
            return new Ship();
        }
    }

    [Serializable]
    public class Ship : Vehicle
    {
        public String shipClass;
        public String deckCount;

        public Ship()
        {

        }

        public Ship(String model, String color, int madeYear, String _shipClass, String _deckCount)
            : base(model, color, madeYear)
        {
            this.shipClass = _shipClass;
            this.deckCount = _deckCount;
        }

        public void Update(String model, String color, int madeYear, String _shipClass, String _deckCount)
        {
            base.Update(model, color, madeYear);

            this.shipClass = _shipClass;
            this.deckCount = _deckCount;
        }

        public override String GetString()
        {
            return "Sailboard: " + this.model + ", color: " + this.color + ", made year: " + this.madeYear + ", ship class: " + this.shipClass + ", deck count: " + this.deckCount + ")";
        }
    }
}
