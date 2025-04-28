// Return the sum of the numbers in the array, returning 0 for an empty array. Except the number 13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do not count.

using System;

class Testing {
    public static int Sum13(int[] nums) {
        int adder = 0;
        foreach (int i in nums) {
            if (i == 13) {
                break;
            }
            adder += i;
    }
    return adder;
}
}

class Program
{
    public static void Main(string[] args)
    {
        int[] Thirteen = new int[] {1, 2, 3, 13, 5, 6, 7};
        Console.WriteLine(Testing.Sum13(Thirteen));
    }
}
