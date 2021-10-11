using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitappbranches
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Count() > 0)
                Console.WriteLine($"hi {args[0]}");
            else
            {
                Console.WriteLine("There are noone to greet, please enter a name");
                var name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    Console.WriteLine($"hi {name}");
            }
            Console.ReadLine();
        }
    }
}
