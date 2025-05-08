using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass4
{
    internal class TaskList
    {

        List<Task> tasks=new List<Task>();

        public static TaskList operator +(TaskList TL,Task t)
        {
            TL.tasks.Add(t);
            return TL;
        }

    }
}
