using Lesson3_Inhertitance.Abstract;
using Lesson3_Inhertitance.Common;
using Lesson3_Inhertitance.Entities;

//See https://aka.ms/new-console-template for more information
//Semantik olarak inheritance
/*
BaseClass baseClass = new();
baseClass.Text = "test";
DerivedClass derivedClass = new DerivedClass();
derivedClass.Text = "test2";
class BaseClass //Parent classs == Kalitim veren
{
    public string Text { get; set; }

    public void Print()
    {
        Console.WriteLine("Print Method");
    }
}

class DerivedClass : BaseClass // Child == Kalitim alan Class  : BaseClass ile kalitim aldik artik baseclassdaki memberlar derivedclassin icinde de var
{

}

*/


Console.WriteLine("Calendar App");

Meeting meeting1 = new Meeting()
{
    Title = "meeting Test",
    Details = new List<string>()
    {
        "meeting details test"
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Gusets = new List<string>() { "mail1", "mail2", "mail3"},
};

Todo todo1 = new Todo()
{
    Title = "todo Test",
    Details = new List<string>()
    {
        "todo details test"
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Importance = "High Priority",
};

todo1.GetNotification();

meeting1.GetNotification();