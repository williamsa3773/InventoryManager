//MainMenu.cs
using System;

namespace InventoryManager
{
    public class MainMenu
    {
        public static void MainMenuMessage() 
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Inventory Manager");
            int menuOption = 0;

            do
            {
                Console.WriteLine("Please Select an option");
                Console.WriteLine("1. Create a new inventory list.");
                Console.WriteLine("2. Load an inventory list");
                Console.WriteLine("3. Exit Application");

                menuOption = Helper.convertOptions(Console.ReadLine());
            } while(menuOption != 3);
        }

        
    }
}