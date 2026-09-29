using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal class Driver
    {
        public string Name { get; set; }
        public string LicenseNumber { get; set; }

        public Driver(string name, string licenseNumber)
        {
            Name = name;
            LicenseNumber = licenseNumber;
        }

        public void PrintDriverInfo()
        {
            Console.WriteLine($"Driver Name   : {Name}");
            Console.WriteLine($"License Number: {LicenseNumber}");
        }
    }
}
