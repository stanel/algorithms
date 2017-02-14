using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion
{
    public class Fibonacci
    {
        public int GetNumber(int position)
        {
            if (position <= 0)
                return 0;

            if (position == 1)
                return 1;

            return GetNumber(position-2) + GetNumber(position-1);
        }
    }
}
