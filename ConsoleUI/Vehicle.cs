using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Make { get; set; } = "Some make";
        public string Model { get; set; } = "Some model";
        public string Year { get; set; } = "Some Year";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {Year} {Make} {Model} is driving.");
        }
    }


}
