using System;

class Testing {
    public static int[] SelectionSort(int[] nums) {
        for (int cursor = 0; cursor < nums.Length-1; cursor++) {
            int smallest = cursor;
            for (int i = cursor + 1; i < nums.Length; i++) {
                if (nums[smallest] > nums[i]) {
                    smallest = i;
                }
            }
            int temp = nums[cursor];
            nums[cursor] = nums[smallest];
            nums[smallest] = temp;
        }
        return nums;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {4, 5, 3, 1, 2};
        int[] sorted = Testing.SelectionSort(nums);
        foreach (int t in sorted) {
            Console.WriteLine(t);
        }
    }
}
