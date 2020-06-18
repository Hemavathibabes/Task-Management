using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

using taskmanangement.Models;
using taskmanangement.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;

namespace taskmanangement
{

    class Program
    {
        static void Main(string[] args)
        {
            loginuser lu = new loginuser();
            ValidateLogin vl= new ValidateLogin();
            Addtask at = new Addtask();
            Showtask st = new Showtask();
            AddComment ac = new AddComment();
            Showcomments sc = new Showcomments();
            List<loginuser> user;
            user= lu.addloginuser();
            
           Console.WriteLine("Login Page");
            Console.WriteLine("Enter the user name:");
           String Username = Console.ReadLine();
             Console.WriteLine("Enter the password:");
             String Password = Console.ReadLine();
            

           if( !(vl.loginvalidate(Username, Password,user)))
            {
                Environment.Exit(0);
            }
           

            bool flag = true;

            List<Task> task=null;
            List<Comments> comments = null;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("1.Add a Task\n2.Show tasks assigned to me\n3.WriteComments\n4.Show Comments\n5.Logout");
                Console.WriteLine("Enter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            task= at.addtask(Username);
                            
                            break;
                               
                        }
                    case 2:
                        {

                            st.showtask(Username, task);
                                break;
                            
                        }
                    case 3:
                        {
                            comments=ac.Addcomment(Username,task);
                            break;
                        }
                    case 4:
                        {
                            sc.showcomments(Username, comments);
                            break;
                        }
                    case 5:
                        {
                            Username = " ";
                            Console.WriteLine("Successfully Logout!!");
                            break;
                        }

                }
               
                Console.WriteLine("Do You want to continue? yes/no");
                String ans = Console.ReadLine();
                if (ans == "yes" || ans == "y" || ans == "Yes")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            


            

        }
    }
}
