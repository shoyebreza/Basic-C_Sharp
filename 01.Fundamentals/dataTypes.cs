using System;
namespace DataTypes
{
    class DataTyp
    {
        static void Main()
        {
            char a = 'A';

            int i = 88;

            short s = 56;

            long l = 674567567;

            uint ui = 456;

            ulong ul = 4756;

            ushort us = 76;

            double d = 76467567;

            float f = 3.456456f;

            decimal dec = 389.5m;


            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
        }
    }
}