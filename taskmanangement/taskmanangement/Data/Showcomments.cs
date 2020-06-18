using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using taskmanangement.Models;

namespace taskmanangement.Data
{
    class Showcomments:IShowcomments
    {
        bool ifusergivescomments = false;
        public void showcomments(string username,List<Comments> comments)
        {
            if (username == " ")

            {
                Console.WriteLine("Log in please!!");
            }
            else
            {
                Console.WriteLine("If u want to fetch the comments for the particular task? yes/no");
                string ans = Console.ReadLine();
                if (ans == "yes" || ans == "Yes")
                {
                    Console.WriteLine("Enter the task id :");
                    int t_id = Convert.ToInt32(Console.ReadLine());
                    foreach (Comments c in comments)
                    {
                        if (t_id== c.taskid)
                        {
                            ifusergivescomments = true;
                            Console.WriteLine("Comments posted for the task id {0}:", t_id);
                            Console.WriteLine("Username:{0} \n Comment:{1}\n", c.username, c.commentsummary);

                        }
                    }
                    if (ifusergivescomments == false)
                    {
                        Console.WriteLine("No comments are pushed for task id:{0}", t_id);
                    }

                }
                else
                {



                    foreach (Comments c in comments)
                    {
                        if (username == c.username)
                        {
                            ifusergivescomments = true;
                            Console.WriteLine("Comments posted by {0}", username);
                            Console.WriteLine("Task id:{0} \n Comment:{1}\n", c.taskid, c.commentsummary);

                        }
                    }
                    if (ifusergivescomments == false)
                    {
                        Console.WriteLine("{0} does not gives anycomment", username);
                    }


                }
            }

        }
    }
}
