using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarr = { 1, 2, 3 };
            double[] doublearr = {12.2,125.2,45.4,5.2,23.5};
            char[] chararr = { 'a', 'b', 'c', 'd', 'e', 'f', };
            PrintArray.printAnArray(intarr);
            PrintArray.printAnArray(doublearr);
            PrintArray.printAnArray(chararr);
            Console.ReadLine();
        }
    }
}
