using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getri_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(new Processor(10));

            Console.ReadLine();
        }
    }

    public class Computer
    {
        Processor processor;
        public Computer(Processor _processor)
        {
            processor = _processor;
            Console.WriteLine("Computer Class Called");
        }        
    }

    public class Processor
    {
        public Processor(int speed)
        {
            Console.WriteLine($"{speed}");
            Console.WriteLine("Processor Class Called");
        }
    }
}
