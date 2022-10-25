using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static int migratoryBirds(List<int> arr)
        {
            arr.Sort();
            List<int> distinctArr = arr.Distinct().ToList();
            List<int> distinctCount = new List<int>();
            
            foreach (var item in distinctArr)
            {
                distinctCount.Add(arr.Where(el => el == item).Count());
            }

            return distinctArr[distinctCount.IndexOf(distinctCount.Max())];
        }
    }
}