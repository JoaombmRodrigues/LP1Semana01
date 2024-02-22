using System;
using System.Net;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex7.2.1
            Console.WriteLine("Insert an integer number: ");
            string str = Console.ReadLine();
            //ex7.2.2
            int response = int.Parse(str);
        }
    }
}
