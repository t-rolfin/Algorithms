using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sorting.Utilities
{
    public class Manager
    {
        public ISorting Sorting { get; protected set; }

        public void CreateSorting(string typeOfSorting, int[] array)
        {
            var listOfSortingTypes = Utility.GetAllSortingTypesFromAssambly();

            var sortingType = listOfSortingTypes.Find(x => x.Name == typeOfSorting);
            this.Sorting = (ISorting)Activator.CreateInstance(sortingType, array);
        }

    }
}
