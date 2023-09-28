using lessons2_OOP.Enums;
using lessons2_OOP.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons2_OOP.Entities.ComputerComponents
{
    internal class Ram
    {
        public string Brand { get; set; }
       // public int Size { get; set; }    VALUE OBJECT KULLANDIK
       // public CapacitySizeType SizeType { get; set; } BUNLARA GEREK KALMADI
       public Capacity Capacity { get; set; }
        public Ram() { }

        public Ram(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;

        }
    }
}

