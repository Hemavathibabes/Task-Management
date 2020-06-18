using System;
using System.Collections.Generic;
using System.Text;
using taskmanangement.Models;

namespace taskmanangement.Data
{
    class AddComment:IAddcomments
    {
        List<Comments> comments = new List<Comments>();
       
        public List<Comments> Addcomment(string username,List<Task> task)
        {
            if (username == " ")
            {
                Console.WriteLine("Please Login!!");
                return comments;
            }
            else
            {
                bool ifcommentable = false;
                Console.WriteLine("Enter the task id");
                int t_id = Convert.ToInt32(Console.ReadLine());
                foreach (Task t in task)
                {
                    if (t_id == t.taskid)
                    {
                        ifcommentable = true;
                        break;
                    }

                }
                if (ifcommentable == true)
                {
                    Console.WriteLine("Enter the comment");
                    String comment = Console.ReadLine();
                    Comments newcomments = new Comments(t_id, username, comment);
                    comments.Add(newcomments);
                    Console.WriteLine("Comment pushed Sucessfully!!");
                }
                else
                {
                    Console.WriteLine("There is no more task for this id");
                }
            }
            return comments;
        }
    }
}
