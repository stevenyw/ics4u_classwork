using System;

class Program
{
    public static void BubbleSort(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++) {
            Console.WriteLine(nums[i] + " " + nums[i + 1]);
            if (nums[i] > nums[i + 1]) {
                Console.WriteLine("swap em!");
                int tmp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = tmp;
            }
        }

        // Print the array after the pass
        Console.WriteLine("final result");
        foreach (int n in nums) {
            Console.WriteLine(n);
        }
    }
// Loop through the list comparing each set of neighbours
// If they're out of order, swap em.
// Do this over and over
    public static void Main(string[] args)
    {
        int[] nums = new int[] {4, 2, 6, 1, 9};
        BubbleSort(nums);
    }
}
