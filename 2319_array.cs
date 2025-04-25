using System;

class Testing {
    public static bool Sum28(int[] nums) {
        int thing = 0;
        foreach (int n in nums) {
            if (n == 2) {
                thing += n;
        }
        }
        if (thing == 8) {
            return true;
        }
        else {
            return false;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] Test = new int[] {2, 4, 5, 9, 2, 2, 2};
        Console.WriteLine(Testing.Sum28(Test));
    }
}
