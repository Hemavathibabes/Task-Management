using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


interface Taskmanager
{
    public int taskid { get; set; }
    public String taskname { get; set; }
    public String taskdescription { get; set; }
    public DateTime Assignedat { get; set; }
    public DateTime startdate { get; set; }
    public DateTime enddate { get; set; }
    public string assignedto { get; set; }
    public string assignedby { get; set; }

}
interface IAddTask
{
    public List<Task> addtask(string username);
    

}
interface IShowTask
{
    public void showtask(string username,List<Task> task) ;

}
class Task: Taskmanager
{
        public int taskid { get; set; }
        public String taskname { get; set; }
        public String taskdescription { get; set; }
        public DateTime Assignedat { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public string assignedto { get; set; }
        public string assignedby { get; set; }
    

    public Task(int id, string name, string description, DateTime assignedat, DateTime startdate, DateTime enddate, string assignedto_uname, string assignedby_uname)
    {
        this.taskid = id;
        this.taskname = name;
        this.taskdescription = description;
        this.Assignedat = assignedat;
        this.startdate = startdate;
        this.enddate = enddate;
        this.assignedto = assignedto_uname;
        this.assignedby = assignedby_uname;
    }

    

}
