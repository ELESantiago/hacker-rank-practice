using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(FibonnacciSumOfEven(n));
        }
    }

    static long FibonnacciSumOfEven(long n)
    {
        long sum = 0;
        long curr = 0;
        long next = 2;
        while (next < n)
        {
            sum += next;
            var prev = curr;
            curr = next;
            next = next * 4 + prev;
        }

        return sum;
    }
}
