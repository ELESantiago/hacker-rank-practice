using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long multiplesOfThreeAndFive(int n)
    {
        return sum(n - 1, 3) + sum(n - 1, 5) - sum(n - 1, 15);
    }

    static long sum(int n, long k)
    {
        var d = Math.Floor((decimal)n / k);
        return k * (long)Math.Floor(((d * (d + 1)) / 2));
    }
}
