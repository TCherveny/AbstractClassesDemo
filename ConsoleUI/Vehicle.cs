using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public abstract class Vehicle
    {
        public int Year { get; set; } = 0000;
        public string Make { get; set; } = "No Input Recieved";
        public string Model { get; set; } = "No Input Recieved";

        public abstract void DriveAbstract();    // ABSTRACT AKA STUBBED OUT method 

        public virtual void DriveVirtual()
        {
            //Console.WriteLine($"This {GetType().Name} is virtually in drive");
            Console.WriteLine("This vehicle is virtually in drive");
        }
    }




    /*
          DONE   * Create an abstract class called Vehicle
          DONE   * The vehicle class shall have three string properties Year, Make, and Model
          DONE   * Set the defaults to something generic in the Vehicle class
          DONE   * Vehicle shall have an abstract method called DriveAbstract with no implementation
          DONE   * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
}
