using System;

class Testing {
    public static int CenteredAverage(int[] nums) {
        int adder = 0;
        int index = 0;
       for (int i = 1; i < nums.Length - 1; i++) {
            if (nums[0] == nums[1] || nums[nums.Length-1] == nums[nums.Length-2]) {
                index += 0;
                adder += 0;
            }
            adder += nums[i];
            index += 1;
        }
        return adder / index;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] ArrayThing = new int[] {2, 2, 4, 9, 14, 17, 17};
        Console.WriteLine(Testing.CenteredAverage(ArrayThing));
    }
}
