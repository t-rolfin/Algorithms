using sorting.Utilities;
using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Insertions.InsertArray();
            string typeOfSorting = Insertions.InsertTypeOfSorting();

            var manager = new Manager();
            manager.CreateSorting(typeOfSorting, array);
            var sortedArray = manager.Sorting.Sort();

            Insertions.PrintSortedArray(sortedArray);

            Console.ReadLine();
        }
    }
}
