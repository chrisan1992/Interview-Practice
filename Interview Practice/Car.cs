using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class Car
    {
        private string make;
        private int hp;
        private int torque;

        public Car()
        {

        }

        public Car(Car c)
        {
            this.make = c.make;
            this.hp = c.hp;
            this.torque = c.torque;
        }

        public string Make
        {
            set
            { this.make = value; }
            get
            { return this.make; }
        }

        public int HP
        {
            set { this.hp = value; }
            get { return this.hp; }
        }

        public int Torque
        {
            set { this.torque = value; }
            get { return this.torque; }
        }
    }
}
