using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");

            Run();
        }

        public static void Run()
        {
            bool isRunning = true;
            int choice = -1;

            MenuSystem menu = new MenuSystem();
            menu.Greeting = "Welcome to the ConsoleMenu application!";
            string[] myMenu = new string[] { "Menu item 1", "Menu item 2", "Menu item 3", "Quit" };
            menu.MenuItems = myMenu;
            menu.Prompt = "Choice->";

            while (isRunning)
            {
                menu.DrawMenu();
                choice = menu.ReadInput();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choice made: 1 yay!");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Choice made: 2 @choicemade");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Choice made: 3 #menusystemsareawesome");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Choice made: 4...Quitting...:(");
                        Console.ReadLine();
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Command not recognized.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
