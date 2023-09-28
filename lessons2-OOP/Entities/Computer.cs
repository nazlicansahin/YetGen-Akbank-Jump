using lessons2_OOP.Entities.ComputerComponents;
using lessons2_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons2_OOP.Entities
{
    internal class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public string CPU { get; set; }
        
        public Storage Storage { get; set; }

        public Ram Ram { get; set; }



        // public Computer() { }  //constructor if you dont create const. It will created like this automaticly

        public Computer()
        {
            Random random = new Random();
            Id = random.Next(1000, int.MaxValue);

        }
        public Computer(string brand, string model) : this() //this() calls const at 22th row   //Constructors dont using only like this. Constructor also a method.
        {

            Brand = brand;
            Model = model;

        }
        public Computer( string brand, string model, string cPU, Ram rAM, Storage storage) : this(brand, model) //this(brand, model) calls const at 28th row 
        {

            CPU = cPU;
            Ram = rAM;
            Storage = storage;
  

        }

        //With this we create more than 1 const and it is polymorphism

    }
}
