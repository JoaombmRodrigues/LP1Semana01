using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex6.1
            double xx = 1.23456;
            int ii = 19;

            //ex4.2
            string message1 = "Hello World!!!";
            string message2 = "\"\u03A9\" really is \\u03A9";
            string message3 = "Here comes the \u263C";
            //ex4.3
            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            //ex5.1
            string message4 = "abc";
            string message5 = "def";
            string message6 = $"Message4 says: {message4}";
            string message7 = $"{message4} + {message5} = {message4+message5}";
            //ex5.2
            Console.WriteLine(message4);
            Console.WriteLine(message5);
            Console.WriteLine(message6);
            Console.WriteLine(message7);
            //ex6.2
            Console.WriteLine
            ($"xx em número real com duas casas decimais: {xx:f2}");
            Console.WriteLine
            ($"xx em percentagem com uma casa decimal: {xx:p1}");
            //ex6.3
            Console.WriteLine($"ii em Hexadecimal: {ii:x}");
            Console.WriteLine($"ii em moeda: {ii:c}");
        }
    }
}
