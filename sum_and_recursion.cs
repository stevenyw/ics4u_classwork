//  Given a non-negative int n, return the sum of its digits recursively (no loops). 
// Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

// sumDigits(126) → 9
// sumDigits(49) → 13
// sumDigits(12) → 3


using System;

class Testing {
    public static int SumDigits(int n) {
        int last = n % 10;
        int rest = n / 10;
        if (n == last) {
            return last;
        }
        return last + SumDigits(rest);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int onetwoeight = Testing.SumDigits(128);
        Console.WriteLine(onetwoeight);
    }
}

// sum(n=128) = return 8 + (12);
// sum(n=128) = return 8 + 1 + (2);
// sum(n=128) = return 11;
