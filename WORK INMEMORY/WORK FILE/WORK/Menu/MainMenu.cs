
using System;
using WORK.Implementation;
using WORK.Interface;

namespace WORK.Menu
{
    public class MainMenu
    {
        public void Main()
        {
            Console.WriteLine(@"
            ((((((((((((((((((((((((((((()))))))))))))))))))))))))))
            (((((((((((((((((((((((((((())))))))))))))))))))))))))))
            ((((( WELCOME TO OLUKOLA NETWORK MANAGEMENT SYSTEM )))))
            (((((((((((((((((((((())))))))))))))))))))))))))))))))))
            (((((((((((((((((((((((((())))))))))))))))))))))))))))))");
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Enter 1 as an Admin: ");
                Console.WriteLine("Enter 2 as a customer: ");
                Console.WriteLine("Enter 0 to Exit application: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    AdminMenu am = new AdminMenu();
                    am.AdminMenu2();
                }
                else if (choice == 2)
                {
                    CustomerMenu cm = new CustomerMenu();
                    cm.CustomerMenu2();
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Shutting Down Application...");
                    isExit = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}