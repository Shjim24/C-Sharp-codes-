using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace LabTask1.cs
{
    public class CarSpeed
    {
        public float acceleration;
        public string engine_number;
        public bool start;
        public float Time;

        public CarSpeed()
        {
            this.acceleration = 0;
            this.engine_number = "";
            this.start = false;
        }
        public bool startCar()
        {
            Console.Out.WriteLine("Car Started");

            return true;
        }
        public bool stopCar()
        {
            Console.Out.WriteLine("Car Stoped");
            return true;
        }
        void SetAcceleration(float acc)
        {
            this.acceleration = acc;
        }
        void Engine_Number(string e_num)
        {
            this.engine_number = e_num;

        }

        public float GetVelocity()
        {
            if (startCar())
            {
                return acceleration* Time;
            }
            else
            {
                Console.Out.WriteLine("Start the car frist");
                return 0;
            }
        }


    }
class program
    {
        static void Main(string[] args) 
        {
            Console.Out.WriteLine(" ");
            CarSpeed car1=new CarSpeed();

            Console.Out.WriteLine("Details For Car1");
            Console.Out.WriteLine("Enter the engine Number :");
            car1.engine_number = Console.ReadLine();

            Console.Out.WriteLine("Enter the acceleration :");
            car1.acceleration =float.Parse (Console.ReadLine());

            Console.Out.WriteLine("Enter the time :");
            car1.Time = float.Parse(Console.ReadLine());

            Console.Out.WriteLine("Engine Number of a car set to " +car1.engine_number);
            Console.Out.WriteLine("Velocity of the car after " + car1.Time + " is " + car1.GetVelocity());
            car1.stopCar();

        }
    }
}
