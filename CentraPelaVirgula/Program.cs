using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for numbers
            Console.WriteLine("Input 4 real numbers: ");
            //input numbers
            string resp1 = Console.ReadLine();
            string resp2 = Console.ReadLine();
            string resp3 = Console.ReadLine();
            string resp4 = Console.ReadLine();
            //convert numbers
            float num1 = float.Parse(resp1);
            float num2 = float.Parse(resp2);
            float num3 = float.Parse(resp3);
            float num4 = float.Parse(resp4);
            //print numbers
            Console.WriteLine($"{num1,6:f2}");
            Console.WriteLine($"{num2,6:f2}");
            Console.WriteLine($"{num3,6:f2}");
            Console.WriteLine($"{num4,6:f2}");
        }
    }
}
