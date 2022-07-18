using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
       public int Wheels { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Model} is a {Make} made in {Year}. Like most {Make} motorcycles it only needs {Wheels} wheels!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"The {Model} is a {Make} made in {Year}. It also only needs {Wheels} wheels.");
        }
    }
}
