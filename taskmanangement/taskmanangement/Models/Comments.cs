using System;
using System.Collections.Generic;
using System.Text;


namespace taskmanangement.Models
{
    interface Icomments
    {
        public int taskid { get; set; }
        public string username { get; set; }
        public string commentsummary { get; set; }
    }
    interface IAddcomments
    {
        public List<Comments> Addcomment(string username,List<Task> task);
    }
    interface IShowcomments
    {
        public void showcomments(string username, List<Comments> comments);
    }
    class Comments :Icomments
    {
        public int taskid { get; set; }
        public string username { get; set; }
        public string commentsummary { get; set; }

        public Comments(int id,string u_name,string comments_summary)
        {
            this.taskid = id;
            this.username = u_name;
            this.commentsummary = comments_summary;
           
        }
    }
}
