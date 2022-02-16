using System;
using System.Text;

namespace CSharpFunctions
{

    class Program
    {

        static int addTwoValuesReference(ref int x, ref int y)
        {
            x += 1;
            y -= 1;
            int answer = x + y;
            return answer;
        }

        static void Main(string[] args)
        {
            int value1 = 5, value2 = 4;
            Console.WriteLine($"{addTwoValuesReference(ref value1, ref value2)} is the answer of adding {value1} and {value2}");

            //Tuples 
            (int a, int b) tup1 = (5, 4);
            var tup2 = ("Some text", 23.4f);

            Console.WriteLine($"tup1.a = {tup1.a} and tup1.b = {tup1.b}");
            Console.WriteLine($"tup2.Item1 = {tup2.Item1} and tup2.Item2 = {tup2.Item2}");

            (int x, int y) result = PlusTimes(4, 3);
            Console.WriteLine($"The result of adding is {result.x} and the result of multiplying is {result.y}");
        }//End main

        static (int, int) PlusTimes(int val1, int val2)
        {
            return (val1 + val2, val1 * val2);
        }

    }

}