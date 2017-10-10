using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day2
{
    class Boat
    {


        //these are all fields
        public int numberOfPassengers;
            private string name;
        private double engineSize;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Boat()
        {

        }

        public Boat(int numbberOfpassengers,string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;


        }

        public void Move()
        {
            // coden to mmake the boat move
            Console.WriteLine("boaty moves foward");
        }

        private double CalculateMPG()
        {//claculat MPG

            double MPG = engineSize * 7d;
            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("passengers :" + numberOfPassengers);
            Console.WriteLine("Engine size " + engineSize);
            Console.WriteLine("MPG " + CalculateMPG());// this CalculateMPG is set to private. in can be accesed in another method
        }

    }

}
