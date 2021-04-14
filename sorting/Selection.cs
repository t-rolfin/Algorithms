using sorting.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    public class Selection : ISorting
    {
        private int[] array;

        public Selection(int[] array)
        {
            this.array = array;
        }

        public int[] Sort()
        {
            int minPosition = 0;
            int temp = 0;

            for(int i = 0; i <= array.Length - 1; i++)
            {
                minPosition = i;

                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if(array[j] <= array[minPosition])
                    {
                        minPosition = j;
                    }
                }

                temp = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temp;

            }

            return this.array;
        }
    }
}
