using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.BUS.Helper
{
    internal class PageHelper
    {
        public static int TotalPages(int size, int limit)
        {
            int total = size / limit;
            if (size % limit > 0)
            {
                total += 1;
            }
            return total;
        }

        public static int[] GetStartIndexAndLength(int page, int limit, int listSize)
        {
            int startIndex = (page - 1) * limit;
            int length = limit;
            if (startIndex + length > listSize)
            {
                length = listSize - startIndex;
            }
            return new int[2] {startIndex, length};
        }
    }
}
