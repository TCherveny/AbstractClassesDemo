using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine($"This car is virtually in drive"); //implementation of stubbed out abstract method
        }
      

    }


    /* 
           DONE * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
           DONE * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
           DONE * Provide the implementations for the abstract methods
           DONE * Only in the Motorcycle class will you override the virtual drive method
           */
}
