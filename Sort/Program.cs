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
            CustomSort mySort = new CustomSort();

            int[] InsertionSortList = { 394, 23, 12, 2, 3, 4, 5, 6, 12, 43, 567, 655, 34, 321, 555, 1098, 34, 23, 1, 8, 9, 10 };
            Console.WriteLine("INSERTION SORT");
            mySort.InsertionSort(InsertionSortList);

            int[] SelectionSortList = { 394, 23, 12, 2, 3, 4, 5, 6, 12, 43, 567, 655, 34, 321, 555, 1098, 34, 23, 1, 8, 9, 10 };
            Console.WriteLine("SELECTION SORT");
            mySort.SelectionSort(SelectionSortList);

            int[] myNumbers = { 394, 23, 12, 2, 3, 4, 5, 6, 12, 43, 567, 655, 34, 321, 555, 1098, 34, 23, 1, 8, 9, 10 };
            Console.WriteLine("LINEAR SORT");
            mySort.LinearSort(myNumbers);

            int[] myNumbers2 = { 394, 23, 12, 2, 3, 4, 5, 6, 12, 43, 567, 655, 34, 321, 555, 1098, 34, 23, 1, 8, 9, 10 };
            Console.WriteLine("\nBUBBLE SORT");
            mySort.BubbleSort(myNumbers2);

            int[] myNumbers3 = { 394, 23, 12, 2, 3, 4, 5, 6, 12, 43, 567, 655, 34, 321, 555, 1098, 34, 23, 1, 8, 9, 10 };
            Console.WriteLine("\nBUBBLE SORT WITH BREAK");
            mySort.BubbleSortWithBreak(myNumbers3);

            Console.ReadLine();
        }
    }
}

