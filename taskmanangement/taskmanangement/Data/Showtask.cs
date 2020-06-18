using System;
using System.Collections.Generic;
using System.Text;
using taskmanangement.Models;

namespace taskmanangement.Data
{
    class Showtask:IShowTask
    {
        List<Task> task = new List<Task>();
        public void showtask(string username,List<Task> task)
        {
            if (username == " ")

            {
                Console.WriteLine("Log in please!!");
            }

            else
            {
                bool flag2 = false;
                foreach (Task t in task)
                {
                    if (username == t.assignedto)
                    {
                        Console.WriteLine("AssignedBy:{0} at {1}", t.assignedby, t.Assignedat);

                        Console.WriteLine("Taskname:{0}\n Taskid:{1}\n Taskdescription:{2} \nStartdate:{3} \nEnddate:{4} ", t.taskname, t.taskid, t.taskdescription, t.startdate, t.enddate);
                        flag2 = true;
                    }
                }
                if (flag2 == false)
                {
                    Console.WriteLine("No tasks are assigned...Be happy!!");
                }
            }
        }
    }
}
