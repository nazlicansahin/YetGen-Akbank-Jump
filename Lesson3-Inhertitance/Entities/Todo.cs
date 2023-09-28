using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson3_Inhertitance.Abstract;
using Lesson3_Inhertitance.Common;
using Lesson3_Inhertitance.Entities;

namespace Lesson3_Inhertitance.Entities
{
    internal class Todo : Event, INotification
    {

        public string Importance { get; set; }

        public void GetNotification()
        {
            
            Console.WriteLine($"Time to make this To-Do: {Title}");

        }
    }
}
