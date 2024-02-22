using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {   
            //ex3.2
            int int_num = 10;
            short short_num = 47;
            long long_num = 128;
            //ex3.3
            Console.WriteLine(int_num + " " + short_num + " " + long_num);
            //ex3.5
            char estimated_sign = '\u212E';
            char heart = '\u2764';
            char spades = '\u2660';
            //ex3.6
            Console.WriteLine(estimated_sign + " " + heart + " " + spades);
            //ex3.8
            float float_num = 14.7f;
            double double_num = 1.23456;
            decimal decimal_num = 3.1416m;
            //ex3.9
            Console.WriteLine(float_num + " " + double_num + " " + decimal_num);
            //ex3.11
            bool true_condition = true;
            bool false_condition = false;
            //ex3.12
            Console.WriteLine(true_condition + " " + false_condition);
        }
    }
}
