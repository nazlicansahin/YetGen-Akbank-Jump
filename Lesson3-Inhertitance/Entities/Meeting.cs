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
    internal class Meeting : Event, INotification
    {
        public List<string> Gusets { get; set; }

        public void GetNotification()
        {

            foreach (var guest in Gusets)
            {
                Console.WriteLine($"Inviting: {guest}");
            }

        }
    }
}
