using System;
using System.Collections.Generic;
using System.Text;
using taskmanangement.Models;

namespace taskmanangement.Data

{
    class ValidateLogin:Iloginuser
    {
        
      // List<loginuser> user;
       
        public bool loginvalidate(string username, string password,List<loginuser> user)
        {
            bool login = false;
            foreach (loginuser lu in user)
            {

                if (username == lu.username && password == lu.password)
                {
                    Console.WriteLine("Successsfull login!!");
                    Console.WriteLine("Welcome {0}", lu.username);
                }
                login = true;
            }
            if (login == false)
            {
                Console.WriteLine("Username and Password does not match");
                Console.WriteLine("Try again later!");

            }
            return login;

        }
    }
}
