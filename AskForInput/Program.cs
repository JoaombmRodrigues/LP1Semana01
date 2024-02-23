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
            //ex7.2.3
            Console.WriteLine("Insert a real number: ");
            string str2 = Console.ReadLine();
            //ex7.3.4
            float response2 = float.Parse(str);
            //ex7.3.5
            Console.WriteLine($"{response}+{response2}={response+response2}");
        }
    }
}
