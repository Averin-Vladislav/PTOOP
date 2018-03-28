namespace PTOOP_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.add_car = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_car = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.design = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carrying_capacity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edit_bicycle = new System.Windows.Forms.Button();
            this.sport = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wheel_count = new System.Windows.Forms.TextBox();
            this.add_bicycle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edit_motorcycle = new System.Windows.Forms.Button();
            this.buggy = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.add_motorcycle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edit_sailboard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sail_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.board_class = new System.Windows.Forms.TextBox();
            this.add_sailboard = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.edit_train = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.traction_type = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.carriage_count = new System.Windows.Forms.TextBox();
            this.add_train = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.made_year = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.vehicle_list = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.serialize = new System.Windows.Forms.Button();
            this.deserialize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_car
            // 
            this.add_car.Location = new System.Drawing.Point(10, 70);
            this.add_car.Name = "add_car";
            this.add_car.Size = new System.Drawing.Size(98, 23);
            this.add_car.TabIndex = 2;
            this.add_car.Text = "Add";
            this.add_car.UseVisualStyleBackColor = true;
            this.add_car.Click += new System.EventHandler(this.add_car_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edit_car);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.design);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.carrying_capacity);
            this.groupBox1.Controls.Add(this.add_car);
            this.groupBox1.Location = new System.Drawing.Point(259, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car";
            // 
            // edit_car
            // 
            this.edit_car.Location = new System.Drawing.Point(119, 70);
            this.edit_car.Name = "edit_car";
            this.edit_car.Size = new System.Drawing.Size(100, 23);
            this.edit_car.TabIndex = 7;
            this.edit_car.Text = "Edit";
            this.edit_car.UseVisualStyleBackColor = true;
            this.edit_car.Click += new System.EventHandler(this.edit_car_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Design";
            // 
            // design
            // 
            this.design.Location = new System.Drawing.Point(119, 45);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(100, 20);
            this.design.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carrying capacity";
            // 
            // carrying_capacity
            // 
            this.carrying_capacity.Location = new System.Drawing.Point(119, 17);
            this.carrying_capacity.Name = "carrying_capacity";
            this.carrying_capacity.Size = new System.Drawing.Size(100, 20);
            this.carrying_capacity.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edit_bicycle);
            this.groupBox2.Controls.Add(this.sport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.wheel_count);
            this.groupBox2.Controls.Add(this.add_bicycle);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 99);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bicycle";
            // 
            // edit_bicycle
            // 
            this.edit_bicycle.Location = new System.Drawing.Point(119, 70);
            this.edit_bicycle.Name = "edit_bicycle";
            this.edit_bicycle.Size = new System.Drawing.Size(100, 23);
            this.edit_bicycle.TabIndex = 8;
            this.edit_bicycle.Text = "Edit";
            this.edit_bicycle.UseVisualStyleBackColor = true;
            this.edit_bicycle.Click += new System.EventHandler(this.edit_bicycle_Click);
            // 
            // sport
            // 
            this.sport.AutoSize = true;
            this.sport.Location = new System.Drawing.Point(119, 48);
            this.sport.Name = "sport";
            this.sport.Size = new System.Drawing.Size(51, 17);
            this.sport.TabIndex = 7;
            this.sport.Text = "Sport";
            this.sport.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wheel count";
            // 
            // wheel_count
            // 
            this.wheel_count.Location = new System.Drawing.Point(119, 17);
            this.wheel_count.Name = "wheel_count";
            this.wheel_count.Size = new System.Drawing.Size(100, 20);
            this.wheel_count.TabIndex = 3;
            // 
            // add_bicycle
            // 
            this.add_bicycle.Location = new System.Drawing.Point(6, 70);
            this.add_bicycle.Name = "add_bicycle";
            this.add_bicycle.Size = new System.Drawing.Size(103, 23);
            this.add_bicycle.TabIndex = 2;
            this.add_bicycle.Text = "Add";
            this.add_bicycle.UseVisualStyleBackColor = true;
            this.add_bicycle.Click += new System.EventHandler(this.add_bicycle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edit_motorcycle);
            this.groupBox3.Controls.Add(this.buggy);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.type);
            this.groupBox3.Controls.Add(this.add_motorcycle);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 99);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motorcycle";
            // 
            // edit_motorcycle
            // 
            this.edit_motorcycle.Location = new System.Drawing.Point(116, 70);
            this.edit_motorcycle.Name = "edit_motorcycle";
            this.edit_motorcycle.Size = new System.Drawing.Size(103, 23);
            this.edit_motorcycle.TabIndex = 8;
            this.edit_motorcycle.Text = "Edit";
            this.edit_motorcycle.UseVisualStyleBackColor = true;
            this.edit_motorcycle.Click += new System.EventHandler(this.edit_motorcycle_Click);
            // 
            // buggy
            // 
            this.buggy.AutoSize = true;
            this.buggy.Location = new System.Drawing.Point(119, 48);
            this.buggy.Name = "buggy";
            this.buggy.Size = new System.Drawing.Size(56, 17);
            this.buggy.TabIndex = 7;
            this.buggy.Text = "Buggy";
            this.buggy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(119, 17);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 3;
            // 
            // add_motorcycle
            // 
            this.add_motorcycle.Location = new System.Drawing.Point(10, 70);
            this.add_motorcycle.Name = "add_motorcycle";
            this.add_motorcycle.Size = new System.Drawing.Size(99, 23);
            this.add_motorcycle.TabIndex = 2;
            this.add_motorcycle.Text = "Add";
            this.add_motorcycle.UseVisualStyleBackColor = true;
            this.add_motorcycle.Click += new System.EventHandler(this.add_motorcycle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.edit_sailboard);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.sail_type);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.board_class);
            this.groupBox4.Controls.Add(this.add_sailboard);
            this.groupBox4.Location = new System.Drawing.Point(259, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 99);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sailboard";
            // 
            // edit_sailboard
            // 
            this.edit_sailboard.Location = new System.Drawing.Point(119, 70);
            this.edit_sailboard.Name = "edit_sailboard";
            this.edit_sailboard.Size = new System.Drawing.Size(100, 23);
            this.edit_sailboard.TabIndex = 7;
            this.edit_sailboard.Text = "Edit";
            this.edit_sailboard.UseVisualStyleBackColor = true;
            this.edit_sailboard.Click += new System.EventHandler(this.edit_sailboard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sail type";
            // 
            // sail_type
            // 
            this.sail_type.Location = new System.Drawing.Point(119, 45);
            this.sail_type.Name = "sail_type";
            this.sail_type.Size = new System.Drawing.Size(100, 20);
            this.sail_type.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Board class";
            // 
            // board_class
            // 
            this.board_class.Location = new System.Drawing.Point(119, 17);
            this.board_class.Name = "board_class";
            this.board_class.Size = new System.Drawing.Size(100, 20);
            this.board_class.TabIndex = 3;
            // 
            // add_sailboard
            // 
            this.add_sailboard.Location = new System.Drawing.Point(10, 70);
            this.add_sailboard.Name = "add_sailboard";
            this.add_sailboard.Size = new System.Drawing.Size(98, 23);
            this.add_sailboard.TabIndex = 2;
            this.add_sailboard.Text = "Add";
            this.add_sailboard.UseVisualStyleBackColor = true;
            this.add_sailboard.Click += new System.EventHandler(this.add_sailboard_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.edit_train);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.traction_type);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.carriage_count);
            this.groupBox5.Controls.Add(this.add_train);
            this.groupBox5.Location = new System.Drawing.Point(259, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 99);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Train";
            // 
            // edit_train
            // 
            this.edit_train.Location = new System.Drawing.Point(117, 70);
            this.edit_train.Name = "edit_train";
            this.edit_train.Size = new System.Drawing.Size(102, 23);
            this.edit_train.TabIndex = 7;
            this.edit_train.Text = "Edit";
            this.edit_train.UseVisualStyleBackColor = true;
            this.edit_train.Click += new System.EventHandler(this.edit_train_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Traction type";
            // 
            // traction_type
            // 
            this.traction_type.Location = new System.Drawing.Point(119, 45);
            this.traction_type.Name = "traction_type";
            this.traction_type.Size = new System.Drawing.Size(100, 20);
            this.traction_type.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Carriage count";
            // 
            // carriage_count
            // 
            this.carriage_count.Location = new System.Drawing.Point(119, 17);
            this.carriage_count.Name = "carriage_count";
            this.carriage_count.Size = new System.Drawing.Size(100, 20);
            this.carriage_count.TabIndex = 3;
            // 
            // add_train
            // 
            this.add_train.Location = new System.Drawing.Point(6, 70);
            this.add_train.Name = "add_train";
            this.add_train.Size = new System.Drawing.Size(102, 23);
            this.add_train.TabIndex = 2;
            this.add_train.Text = "Add";
            this.add_train.UseVisualStyleBackColor = true;
            this.add_train.Click += new System.EventHandler(this.add_train_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.made_year);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.color);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.model);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(225, 99);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Common parameters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Made year";
            // 
            // made_year
            // 
            this.made_year.Location = new System.Drawing.Point(119, 73);
            this.made_year.Name = "made_year";
            this.made_year.Size = new System.Drawing.Size(100, 20);
            this.made_year.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Color";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(119, 45);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 20);
            this.color.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Model";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(119, 17);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 20);
            this.model.TabIndex = 3;
            // 
            // vehicle_list
            // 
            this.vehicle_list.FormattingEnabled = true;
            this.vehicle_list.Location = new System.Drawing.Point(12, 350);
            this.vehicle_list.Name = "vehicle_list";
            this.vehicle_list.Size = new System.Drawing.Size(399, 121);
            this.vehicle_list.TabIndex = 12;
            this.vehicle_list.SelectedIndexChanged += new System.EventHandler(this.on_index_selected);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Vehicle List";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(417, 350);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(67, 38);
            this.remove.TabIndex = 14;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // serialize
            // 
            this.serialize.Location = new System.Drawing.Point(417, 394);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(67, 35);
            this.serialize.TabIndex = 15;
            this.serialize.Text = "Serialize";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // deserialize
            // 
            this.deserialize.Location = new System.Drawing.Point(417, 435);
            this.deserialize.Name = "deserialize";
            this.deserialize.Size = new System.Drawing.Size(67, 36);
            this.deserialize.TabIndex = 16;
            this.deserialize.Text = "Deserialize";
            this.deserialize.UseVisualStyleBackColor = true;
            this.deserialize.Click += new System.EventHandler(this.deserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 476);
            this.Controls.Add(this.deserialize);
            this.Controls.Add(this.serialize);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vehicle_list);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PTOOP_3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button add_car;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox carrying_capacity;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox design;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox wheel_count;
        public System.Windows.Forms.Button add_bicycle;
        public System.Windows.Forms.CheckBox sport;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.CheckBox buggy;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox type;
        public System.Windows.Forms.Button add_motorcycle;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox board_class;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox sail_type;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox traction_type;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox carriage_count;
        public System.Windows.Forms.Button add_train;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox color;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox model;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox made_year;
        public System.Windows.Forms.ListBox vehicle_list;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button remove;
        public System.Windows.Forms.Button edit_bicycle;
        public System.Windows.Forms.Button edit_motorcycle;
        public System.Windows.Forms.Button edit_car;
        public System.Windows.Forms.Button edit_sailboard;
        public System.Windows.Forms.Button add_sailboard;
        public System.Windows.Forms.Button edit_train;
        public System.Windows.Forms.Button serialize;
        public System.Windows.Forms.Button deserialize;
    }
}

