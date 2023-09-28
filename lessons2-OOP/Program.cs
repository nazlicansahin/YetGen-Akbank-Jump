// See https://aka.ms/new-console-template for more information
using lessons2_OOP.Entities;
using lessons2_OOP.Entities.ComputerComponents;
using lessons2_OOP.Enums;
using lessons2_OOP;
using lessons2_OOP.ValueObjects;

Computer computer = new Computer();
Computer computer1 = new Computer("Apple", "mb pro");
/*Storage storage1 = new Storage()
{
    Brand =  "WD Blue",
    Size = 100,
    SizeType = CapacitySizeType.TB
};
*/
//Storage storage1 = new Storage("WD", 1, CapacitySizeType.MB); OBJECT VALUE KULLANDIK BUNA GEREK KALMADI

Storage storage1 = new Storage("WD", new Capacity(1, CapacitySizeType.GB));

//Ram ram1 = new("Kingston", 8, CapacitySizeType.GB);  OBJECT VALUE KULLANDIK BUNA GEREK KALMADI


//Capacity capacity1 = new Capacity(16, CapacitySizeType.GB);  AYRI BIR DEGISKEN KULLANMAK YERINE
//Ram ram1 = new("Kingston",capacity1);                         ICINDE KUCAGIRDIK BUNA DA GEREK KALMADI

;
Ram ram1 = new("Kingston", new Capacity(16, CapacitySizeType.GB));

Computer computer2 = new Computer("Apple", "mb pro","i7", ram1, storage1);
