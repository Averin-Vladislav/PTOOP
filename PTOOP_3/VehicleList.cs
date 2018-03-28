using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTOOP_3
{
    [Serializable]
    class VehicleList
    {
        public List<Vehicle> vehicleList { get; set; }

        public VehicleList()
        {
            vehicleList = new List<Vehicle>();
        }

        public void Add(Vehicle vehicle)
        {
            vehicleList.Add(vehicle);
        }

        public Vehicle Get(int index)
        {
            return vehicleList[index];
        }

        public void Remove(int index)
        {
            this.vehicleList.RemoveAt(index);
        }
    }
}
