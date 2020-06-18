using System;
using System.Collections.Generic;
using System.Text;

namespace taskmanangement.Models
{
    interface Iuser
    {
        public string username { get; set; }
        public string password { get; set; }
        public List<loginuser> addloginuser();
    }
    interface Iloginuser
    {
       
        public bool loginvalidate(string username, string password,List<loginuser> user);
    }
  
       public class loginuser:Iuser
    {
        public string username { get; set; }
        public string password { get; set; }
        
       public  List<loginuser> user = new List<loginuser>();
        public List<loginuser> addloginuser()
        {

            user.Add(new loginuser() { username = "Hema", password = "1234" });
            user.Add(new loginuser() { username = "Banu", password = "5678" });

            return user;

        }

    }
   
    }
