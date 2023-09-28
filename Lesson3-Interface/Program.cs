using System.Reflection;

Console.WriteLine("Interfaces");
SamsungPrinter samsungPrinter = new SamsungPrinter();
samsungPrinter.PrintPage();

//Name Convention isimlendirme gelenigidir
//Interfaceleri isimlendirirken Bas harfi mutlaka i olur


HPPrinter hPPrinter = new HPPrinter();  
hPPrinter.PrintPage();


interface IPrinter
{
    void PrintPage();

}
/*
class Printer
{


 public void PrintPage()
 {
     Console.WriteLine("Printing in color");

 }
}
 */

class SamsungPrinter : IPrinter   // Printer
{
    public void PrintPage()
    {
        Console.WriteLine("Printing black and white");
    }
}


class HPPrinter : IPrinter  //Printer
{
    public void PrintPage()
    {
        Console.WriteLine("Printing in color");
    }
}

//Ayni classdan turettigimiz instancelar farkli ozelliklere sahipse mesela biri renkli yazici biri renksiz burada inheritance olmaz

// classlar arasinda kalitim verme olur ancak bu inheritancede gecerli
// interfacelerde bu implemente etmektir

//Interface oernegini Lesson3-Inheritancedaki app de gosterdik