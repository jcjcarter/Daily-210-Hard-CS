using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_210_Hard_CS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a command string");
            char[] commands = Console.ReadLine().ToCharArray();

            int newX = 0;
            int newY = 0;
            int direction = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'R')
                {
                    if (++direction == 4) direction = 0;
                }
                else if (commands[i] == 'L')
                {
                    if (--direction == -1) direction = 3;
                }
                else if (commands[i] == 'S')
                {
                    switch (direction)
                    {
                        case 0:
                            newY++;
                            break;
                        case 1:
                            newX++;
                            break;
                        case 2:
                            newY--;
                            break;
                        case 3:
                            newX--;
                            break;
                    }
                }
            }
            if (newX == 0 && newY == 0 && direction == 0)
                Console.WriteLine("Loop detected! 1 cycle to complete loop");
            else if (direction == 1 || direction == 3)
                Console.WriteLine("Loop detected! 4 cycles to complete loop");
            else if (direction == 2)
                Console.WriteLine("Loop detected! 2 cycles to complete loop");
            else
                Console.WriteLine("No loop detected!");

            //Suspend the console.
            Console.ReadKey();
        }
    }
}
