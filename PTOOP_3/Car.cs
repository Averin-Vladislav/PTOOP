using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary;

namespace PTOOP_3
{
    [Serializable]
    class Car : Vehicle
    {
        public int carryingСapacity;
        public String design;

        public Car(String model, String color, int madeYear, int _carryingСapacity, String _design)
            : base(model, color, madeYear)
        {
            this.carryingСapacity = _carryingСapacity;
            this.design = _design;
        }

        public void Update(String model, String color, int madeYear, int _carryingСapacity, String _design)
        {
            base.Update(model, color, madeYear);

            this.carryingСapacity = _carryingСapacity;
            this.design = _design;
        }

        public override String GetString()
        {
            return "Car: " + this.model + ", color: " + this.color + ", made year: " + this.madeYear + ", carrying capacity: " + this.carryingСapacity + ", design: " + this.design + ")";
        }
    }
}
