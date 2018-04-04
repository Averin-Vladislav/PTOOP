using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    abstract public class Vehicle
    {
        public String model;
        public String color;
        public int madeYear;

        public Vehicle()
        {

        }

        public Vehicle(String _model, String _color, int _madeYear)
        {
            this.model = _model;
            this.color = _color;
            this.madeYear = _madeYear;
        }

        public void Update(String _model, String _color, int _madeYear)
        {
            this.model = _model;
            this.color = _color;
            this.madeYear = _madeYear;
        }

        public abstract String GetString();
    }
}
