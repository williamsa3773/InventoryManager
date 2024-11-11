//Helper.cs
using System;
using System.Runtime.InteropServices;

namespace InventoryManager
{
    public class Helper
    {
        public static int convertOptions(string option) 
        {
            if(int.TryParse(option, out int result))
            {
                return result;
            }
            else 
            {
                Console.WriteLine("Invalid input. Please enter a number");
                return 0;
            }
        }

    }
}