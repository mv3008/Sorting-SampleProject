using Sorting_SampleProject.examples;
using System;

namespace Sorting_SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 10;
            ArrayHelper obj = new ArrayHelper(maxSize);

            obj.Insert(5);
            obj.Insert(2);
            obj.Insert(3);
            obj.Insert(8);
            obj.Insert(1);
            obj.Insert(42);
            obj.Insert(45);
            obj.Insert(-1);
            obj.Insert(0);
            obj.Insert(-3);

            Console.WriteLine("**************************************Original Input*******************************");

            obj.Display();

            obj.SelectionSort();

            Console.WriteLine("**************************************Final Output*******************************");

            obj.Display();
        }
    }
}
