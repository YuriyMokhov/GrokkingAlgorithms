using System;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch bs = new BinarySearch();
            bs.Search(new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17 }, 2);
            Console.WriteLine("Hello World!");
        }
    }
}
