using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isaac's Big Giveaway");
            Console.Write("Choose a door:1,2 or 3:");
            String userValue = Console.ReadLine();
            String message = "";

            if (userValue == "1")
            {
              message = "You won a new car!";

            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
                message = "You won a new Cat!";
            }
            else
            {
                message = "1-3 you dumb ass!";
            }
            {
                Console.WriteLine(message);
                Console.ReadLine();

            }
        }
   
    }
}
