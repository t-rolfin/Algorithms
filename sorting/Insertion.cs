using sorting.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    public class Insertion : ISorting
    {
        private int[] array;

        public Insertion(int[] array)
        {
            this.array = array;
        }

        public int[] Sort()
        {
            int j;
            int temp;
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                temp = array[i];
                j = i - 1;

                while ((temp < array[j]) && (j >= 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = temp;
            }

            return this.array;
        }
    }
}
