using System;

class Testing {
    public static int[] ExchangeSort(int[] nums) {
        for (int cursor = 0; cursor < nums.Length - 1; cursor++) {
            for (int i = cursor + 1; i < nums.Length; i++) {
                if (nums[cursor] > nums[i]) {
                    int temp = nums[cursor];
                    nums[cursor] = nums[i];
                    nums[i] = temp;
                }
            }
        }
        return nums;
    }
}

class Program {
    public static void Main(string[] args) {
        int[] array = { 5, 3, 4, 1, 2 };
        int[] sorted = Testing.ExchangeSort(array);
        foreach (int t in sorted) {
            Console.WriteLine(t);
}
