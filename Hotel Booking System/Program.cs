using System;
using System.Threading;
using static System.Console;

namespace Hotel_Booking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Orion Hotel Booking System.");
            // Insert admin priviliges here
            Write("Username: ");
            var adminUsername = ReadLine();
            Write("Password: ");
            var adminPassword = ReadLine();

            bool adminPriviliges = adminUsername == "admin" && adminPassword == "admin";

            while (!adminPriviliges)
            {
                if (adminPriviliges)
                {
                    Clear();
                    WriteLine("Logging in...");
                    Thread.Sleep(2000);
                    Clear();
                    WriteLine("Welcome Admin.");
                }
                else
                {
                    WriteLine("Logging in...");
                    Thread.Sleep(2000);
                    Clear();
                    WriteLine("Access denied.");
                    Thread.Sleep(2000);
                    Clear();
                }
            }
        }
    }
}
