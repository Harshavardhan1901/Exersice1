using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide username and password:");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please provide username and password.");
            }
            else if (username == "admin1256" && password == "admin@1256@1256")
            {
                Console.WriteLine("Sign Success");
            }
            else
            {
                Console.WriteLine("Invalid user.");
            }

            Console.ReadLine();
        }
    }
}
