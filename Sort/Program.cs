using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 3, 2, 5, 8, 9, 4, 6, 10, 7, 11, 12, 20, 13, 15, 21, 22, 14, 16, 23, 24, 17, 25, 18, 19 };
            CustomSort mySort = new CustomSort();

            Console.WriteLine("LINEAR SORT");
            mySort.LinearSort(myNumbers);

            int[] myNumbers2 = { 1, 3, 2, 5, 8, 9, 4, 6, 10, 7, 11, 12, 20, 13, 15, 21, 22, 14, 16, 23, 24, 17, 25, 18, 19 };

            Console.WriteLine("\nBUBBLE SORT");
            mySort.BubbleSort(myNumbers2);

            int[] myNumbers3 = { 1, 3, 2, 5, 8, 9, 4, 6, 10, 7, 11, 12, 20, 13, 15, 21, 22, 14, 16, 23, 24, 17, 25, 18, 19 };

            Console.WriteLine("\nBUBBLE SORT WITH BREAK");
            mySort.BubbleSortWithBreak(myNumbers3);

            Console.ReadLine();
        }
    }
}

