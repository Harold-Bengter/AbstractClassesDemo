using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    { 
        public string hasAMotor { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This is a {Year} {Make} {Model} and has a {hasAMotor}. ");
        }
    }
}
