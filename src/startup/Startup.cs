using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management_system.src.startup
{
    public class Startup
    {
        public void WelcomeMessage()
        {
            System.Console.WriteLine();
            Console.WriteLine("Welcome to library management system.");
            Console.WriteLine("Please select your process:");
        }

        public void DisplayOptions()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Add a new book.");
            System.Console.WriteLine("2 - Search for a book.");
            System.Console.WriteLine("3 - Remove an existing book.");
            System.Console.WriteLine("! - Type \"exit\" to exit.");
            System.Console.WriteLine();
        }
    }
}