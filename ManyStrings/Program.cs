using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Hello World!!!";
            string message2 = "\"\u03A9\" really is \\u03A9";
            string message3 = "Here comes the \u263C";
            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
        }
    }
}
