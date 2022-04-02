using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class PrintArray
    {
      public static void printAnArray(int[] arr)
        {
            Console.WriteLine("\ninteger array element");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }
        public static void printAnArray(double[] arr)
        {
            Console.WriteLine("\ndouble array element");
            foreach (double element in arr)
            {
                Console.WriteLine(element);
            }
        }
        public static void printAnArray(char[]arr)
        {
            Console.WriteLine("\nchar array element");
            foreach (char element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }

}
