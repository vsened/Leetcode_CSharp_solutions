using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class FibonacciNumber
    {
        public int Fib(int n)
        {
            var FibonacciList = new List<int> { 0, 1 };
            for (int i = 2; i <= n; i++)
                FibonacciList.Add(FibonacciList[i - 2] + FibonacciList[i - 1]);
            return FibonacciList[n];
        }
    }
}
