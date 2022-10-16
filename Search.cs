using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu5
{
    internal class Search
    {
        public int BinarySearch(int[] arr, int x)
        {
            int i = 0, r = arr.Length - 1;

            while (i <= r)
            {
                int m = i + (r - i) / 2;
                if (arr[m] == x)
                    return m;
                if (arr[m] < x)
                    i = m + 1;
                else
                    r = m - 1;
            }
            return -1;
        }
    }
}
