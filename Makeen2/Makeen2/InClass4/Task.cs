using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass4
{
    internal class Task
    {


        public string Title { get; set; }
        public TaskPriority TaskP { get; set; }

        public bool Status { get; set; }
        public Task(string title, TaskPriority taskP, bool status)
        {
            Title = title;
            TaskP = taskP;
            Status = status;
        }





    }
}
