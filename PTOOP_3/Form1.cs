using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTOOP_3
{
    public partial class Form1 : Form
    {
        private List<String> vehicleList;

        public Form1()
        {
            this.vehicleList = new List<String>();
            InitializeComponent();
            this.vehicle_list.DataSource = this.vehicleList;
        }

        private void add_bicycle_Click(object sender, EventArgs e)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            int wheelCount = int.Parse(this.wheel_count.Text);
            bool isSport = this.sport.Checked;

            Bicycle bicycle = new Bicycle(model, color, madeYear, wheelCount, isSport);
            this.vehicleList.Add("Bicycle(model: " + model + ", color: " + color + ", made year: " + madeYear + ", wheel count: " + wheelCount + ", is sport: " + isSport + ")");
            this.addVehicleToList();
        }

        private void add_motorcycle_Click(object sender, EventArgs e)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            String type = this.type.Text;
            bool isBuggy = this.buggy.Checked;

            Motorcycle motorcycle = new Motorcycle(model, color, madeYear, type, isBuggy);
            this.vehicleList.Add("Motorcycle(model: " + model + ", color: " + color + ", made year: " + madeYear + ", type: " + type + ", is buggy: " + isBuggy + ")");
            this.addVehicleToList();
        }

        private void add_train_Click(object sender, EventArgs e)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            int carriageCount = int.Parse(this.carriage_count.Text);
            String tractionType = this.traction_type.Text;

            Train train = new Train(model, color, madeYear, carriageCount, tractionType);
            this.vehicleList.Add("Train(model: " + model + ", color: " + color + ", made year: " + madeYear + ", carriage count: " + carriageCount + ", traction type: " + tractionType + ")");
            this.addVehicleToList();
        }

        private void add_sailboard_Click(object sender, EventArgs e)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            String boardClass = this.board_class.Text;
            String sailType = this.sail_type.Text;

            Sailboard sailboard = new Sailboard(model, color, madeYear, boardClass, sailType);
            this.vehicleList.Add("Sailboard: " + model + ", color: " + color + ", made year: " + madeYear + ", board class: " + boardClass + ", sail type: " + sailType + ")");
            this.addVehicleToList();
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            int carryingCapacity = int.Parse(this.carrying_capacity.Text);
            String design = this.design.Text;

            Car car = new Car(model, color, madeYear, carryingCapacity, design);
            this.vehicleList.Add("Car: " + model + ", color: " + color + ", made year: " + madeYear + ", carrying capacity: " + carryingCapacity + ", design: " + design + ")");
            this.addVehicleToList();
        }

        private void addVehicleToList()
        {
            this.vehicle_list.DataSource = null;
            this.vehicle_list.DataSource = this.vehicleList;
        }
    }
}
