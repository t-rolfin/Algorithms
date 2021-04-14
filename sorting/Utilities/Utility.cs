using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sorting.Utilities
{
    public static class Utility
    {
        public static List<Type> GetAllSortingTypesFromAssambly()
        {
            var listOfSortingTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.IsAssignableTo(typeof(ISorting)) && x.IsAbstract == false)
                .ToList();

            return listOfSortingTypes;
        }
    }
}
