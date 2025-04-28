// Given an array length 1 or more of ints, return the difference between the largest and smallest values in the array

using System;

class Testing {
    public static int BigDiff(int[] nums) {
        int big = nums[0];
        int small = nums[0];

        foreach (int t in nums) {
            if (t > big) {
                big = t;
            }
            if (t < small) {
                small = t;
            }
        }
        return big - small;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
