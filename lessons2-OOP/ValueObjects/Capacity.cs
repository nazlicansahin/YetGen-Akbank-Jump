using lessons2_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons2_OOP.ValueObjects
{
    internal class Capacity
    {
        public int Size { get; set; } //16
        public CapacitySizeType SizeType { get; set; } // CapacitySizeType.GB 
        public Capacity(int size, CapacitySizeType sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }
    }
}
