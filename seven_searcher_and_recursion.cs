
// Given a non-negative int n, return the count of the occurrences of 7 as a digit, so for example 717 yields 2. (no loops). 
// Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

// count7(717) → 2
// count7(7) → 1
// count7(123) → 0

using System;

class Testing {
    public static int Count7(int n) {
        int last = n % 10;
        int rest = n / 10;
        if (n == 0) {
            return 0;
        }
        if (last == 7) {
            return 1 + Count7(rest);
        }
        else {
        return Count7(rest); }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int seventyseven = Testing.Count7(7227);
        Console.WriteLine(seventyseven);
    }
}

// count7(7227) = return 1 + (722);
// count7(7227) = return 1 + (72);
// count7(7227) = return 1 + (7);
// count7(7227) = return 1 + 1;
// count7(7227) = return 2;
