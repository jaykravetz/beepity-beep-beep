using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beeper
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine("Beep!");
                Console.Beep();

                System.Threading.Thread.Sleep(800);
            }

            Console.WriteLine("Im done beeping now");
            Console.WriteLine("Thank you for listening.");

            System.Threading.Thread.Sleep(2000);

        }
    }
}
