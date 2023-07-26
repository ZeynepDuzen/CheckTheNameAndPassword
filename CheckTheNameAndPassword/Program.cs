using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTheNameAndPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Check the User name and user password ***

            string correctUserName = "zeynep";
            string correctPassword = "12345";
            string userName;
            string password;
            Console.WriteLine("Please enter userName : ");
            userName = Console.ReadLine();
            

            if (userName == correctUserName)
            {
                Console.WriteLine("Please enter password");
                password = Console.ReadLine();

                if (password == correctPassword)
                {
                    Console.WriteLine(userName + " , welcome");
                }
                else
                {
                    Console.WriteLine("the password is incorrect");
                }
            }
            else
            {
                Console.WriteLine("the username is incorrect");
            }



            Console.Read();
        }
    }
}
