using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PTOOP_3
{
    public partial class Form1 : Form
    {
        private List<String> vehicleListOfStrings;
        private VehicleList vehicleList;
        public static Form1 form;
        private int currentIndex;
        private BinaryFormatter formatter;

        public Form1()
        {
            formatter = new BinaryFormatter();
            Form1.form = this;
            this.vehicleListOfStrings = new List<String>();
            this.vehicleList = new VehicleList();
            InitializeComponent();
            this.vehicle_list.DataSource = this.vehicleListOfStrings;
        }

        private void add_bicycle_Click(object sender, EventArgs e)
        {
            this.addBicycle(this.vehicleListOfStrings.Count, true);
        }

        private void add_motorcycle_Click(object sender, EventArgs e)
        {
            this.addMotorcycle(this.vehicleListOfStrings.Count, true);
        }

        private void add_train_Click(object sender, EventArgs e)
        {
            this.addTrain(this.vehicleListOfStrings.Count, true);
        }

        private void add_sailboard_Click(object sender, EventArgs e)
        {
            this.addSailboard(this.vehicleListOfStrings.Count, true);
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            this.addCar(this.vehicleListOfStrings.Count, true);
        }

        private void addCar(int index, bool isNew)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            int carryingCapacity = int.Parse(this.carrying_capacity.Text);
            String design = this.design.Text;
            Car car;

            if (isNew)
            {
                car = new Car(model, color, madeYear, carryingCapacity, design);
                this.vehicleList.Add(car);
            } else
            {
                car = ((Car)this.vehicleList.Get(index));
                car.Update(model, color, madeYear, carryingCapacity, design);
                this.vehicleListOfStrings.RemoveAt(this.currentIndex);
            }
            this.vehicleListOfStrings.Insert(index, car.GetString());
            this.updateVehicleList();
        }

        private void addBicycle(int index, bool isNew)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            int wheelCount = int.Parse(this.wheel_count.Text);
            bool isSport = this.sport.Checked;
            Bicycle bicycle;

            if (isNew)
            {
                bicycle = new Bicycle(model, color, madeYear, wheelCount, isSport);
                this.vehicleList.Add(bicycle);
            }
            else
            {
                bicycle = ((Bicycle)this.vehicleList.Get(index));
                bicycle.Update(model, color, madeYear, wheelCount, isSport);
                this.vehicleListOfStrings.RemoveAt(this.currentIndex);
            }
            this.vehicleListOfStrings.Insert(index, bicycle.GetString());
            this.updateVehicleList();
        }

        private void addMotorcycle(int index, bool isNew)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            String type = this.type.Text;
            bool isBuggy = this.buggy.Checked;
            Motorcycle motorcycle;

            if (isNew)
            {
                motorcycle = new Motorcycle(model, color, madeYear, type, isBuggy);
                this.vehicleList.Add(motorcycle);
            }
            else
            {
                motorcycle = ((Motorcycle)this.vehicleList.Get(index));
                motorcycle.Update(model, color, madeYear, type, isBuggy);
                this.vehicleListOfStrings.RemoveAt(this.currentIndex);
            }
            this.vehicleListOfStrings.Insert(index, motorcycle.GetString());
            this.updateVehicleList();
        }

        private void addTrain(int index, bool isNew)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            int carriageCount = int.Parse(this.carriage_count.Text);
            String tractionType = this.traction_type.Text;
            Train train;

            if (isNew)
            {
                train = new Train(model, color, madeYear, carriageCount, tractionType);
                this.vehicleList.Add(train);
            }
            else
            {
                train = ((Train)this.vehicleList.Get(index));
                train.Update(model, color, madeYear, carriageCount, tractionType);
                this.vehicleListOfStrings.RemoveAt(this.currentIndex);
            }
            this.vehicleListOfStrings.Insert(index, train.GetString());
            this.updateVehicleList();
        }

        private void addSailboard(int index, bool isNew)
        {
            String model = this.model.Text;
            String color = this.color.Text;
            int madeYear = int.Parse(this.made_year.Text);
            String boardClass = this.board_class.Text;
            String sailType = this.sail_type.Text;
            Sailboard sailboard;

            if (isNew)
            {
                sailboard = new Sailboard(model, color, madeYear, boardClass, sailType);
                this.vehicleList.Add(sailboard);
            }
            else
            {
                sailboard = ((Sailboard)this.vehicleList.Get(index));
                sailboard.Update(model, color, madeYear, boardClass, sailType);
                this.vehicleListOfStrings.RemoveAt(this.currentIndex);
            }
            this.vehicleListOfStrings.Insert(index, sailboard.GetString());
            this.updateVehicleList();
        }

        private void updateVehicleList()
        {
            this.vehicle_list.DataSource = null;
            this.vehicle_list.DataSource = this.vehicleListOfStrings;
        }

        private void on_index_selected(object sender, EventArgs e)
        {
            this.currentIndex = this.vehicle_list.SelectedIndex;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            this.vehicleListOfStrings.RemoveAt(this.currentIndex);
            vehicleList.Remove(this.vehicle_list.SelectedIndex);
            this.updateVehicleList();
        }

        private void edit_bicycle_Click(object sender, EventArgs e)
        {
            this.addBicycle(this.currentIndex, false);
        }

        private void edit_car_Click(object sender, EventArgs e)
        {
            this.addCar(this.currentIndex, false);
        }

        private void edit_motorcycle_Click(object sender, EventArgs e)
        {
            this.addMotorcycle(this.currentIndex, false);
        }

        private void edit_train_Click(object sender, EventArgs e)
        {
            this.addTrain(this.currentIndex, false);
        }

        private void edit_sailboard_Click(object sender, EventArgs e)
        {
            this.addSailboard(this.currentIndex, false);
        }

        private void serialize_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("pops.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, vehicleList);
            }
        }

        private void deserialize_Click(object sender, EventArgs e)
        {
            vehicleList = null;

            using (FileStream fs = new FileStream("pops.bin", FileMode.OpenOrCreate))
            {
                vehicleList = (VehicleList)formatter.Deserialize(fs);

                for (int i = 0; i < vehicleList.Size(); i++)
                {
                    vehicleListOfStrings.Add(vehicleList.Get(i).GetString());
                }
            }

            this.updateVehicleList();
        }
    }
}
