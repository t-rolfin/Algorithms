using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sorting.Utilities
{
    public static class Insertions
    {

        public static int[] InsertArray()
        {
            Console.Write("Array capacity: ");
            int.TryParse(Console.ReadLine(), out int capacity);

            int[] array = new int[capacity];

            for (int i = 0; i <= capacity - 1; i++)
            {
                Console.Write($"[{i}]: ");
                int.TryParse(Console.ReadLine(), out int value);
                array[i] = value;
            }

            return array;
        }

        public static string InsertTypeOfSorting()
        {
            Console.WriteLine("Choose what type of sorting do you wanna to use.");

            var listOfSortingTypes = Utility.GetAllSortingTypesFromAssambly().ToArray();

            for(int i = 0; i <= listOfSortingTypes.Count() - 1; i++)
            {
                Console.WriteLine($"[{i}]: {listOfSortingTypes[i].Name}");
            }

            int.TryParse(Console.ReadLine(), out int sortingType);

            return listOfSortingTypes[sortingType].Name;
        }

        public static void PrintSortedArray(int[] array)
        {
            StringBuilder result = new StringBuilder("Sorted array: ");

            for(int i = 0; i <= array.Length -1; i++)
            {
                result.Append(i != array.Length - 1 ? $" {array[i]}," : $" {array[i]} ");
            }

            Console.WriteLine(result.ToString());
        }
    }
}
