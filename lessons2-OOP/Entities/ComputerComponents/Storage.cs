using lessons2_OOP.Enums;
using lessons2_OOP.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons2_OOP.Entities.ComputerComponents
{
    internal class Storage
    {
        public string Brand { get; set; }

        public Capacity Capacity { get; set; }

//        public int Size { get; set; }                        OBJECT VALUE KULLANDIK
//      public CapacitySizeType SizeType { get; set; }          BUNLARA GEREK KALMADI
        public Storage() { }

        public Storage (string brand,  Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;

        }
    }
}
