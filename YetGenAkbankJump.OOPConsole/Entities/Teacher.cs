using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    internal class Teacher : PersonBase
    {
        public DateTimeOffset RegistrationDate { get; set; }
        public void SayMyName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    
    }
}
