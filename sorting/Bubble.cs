using sorting.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    public class Bubble : ISorting
    {
        private int[] array;

        public Bubble(int[] array)
        {
            this.array = array;
        }

        public int[] Sort()
        {
            for(int i = 0; i <= array.Length - 2; i++)
            {
                for(int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        int store = array[i];
                        array[i] = array[j];
                        array[j] = store;
                    }
                }
            }
            return array;
        }

    }
}
