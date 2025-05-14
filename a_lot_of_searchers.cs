using System;

class Testing {
    public static int[] BubbleSort(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++) {
            Console.WriteLine(nums[i] + " " + nums[i+1]);
                if (nums[i] > nums[i+1]) {
                    Console.WriteLine("swap initiated!");
                    int temp = nums[i];
                    nums[i] = nums[i+1];
                    nums[i+1] = temp;
                    Console.WriteLine(nums[i] + " " + nums[i+1]);
                }
            }
            return nums;
        }
    }
    
class TestingTwo {
    public static int[] SelectionSort(int[] nums) {
        Console.WriteLine("selection sort");

        // Outer loop - each pass moves the lowest unsorted element to the front
        for (int cursor = 0; cursor < nums.Length - 1; cursor++) {
            int lowestindex = cursor;

            // Inner loop - find the index of the smallest element in the rest of the array
            for (int i = cursor + 1; i < nums.Length; i++) {
                // If a smaller value is found, update lowestindex
                if (nums[i] < nums[lowestindex]) {
                    lowestindex = i;
                }
            }
                int temp = nums[lowestindex];
                nums[lowestindex] = nums[cursor];
                nums[cursor] = temp; // cursor = 5, and then if a number at index i is lower than index 5, itll be that. and then, it swaps the smallest number with index 5
        }
        return nums;
    }
}

class TestingThree {
    public static int[] BinarySearch(int[] nums) {
        
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int[] apple = new int[] {1, 3, 5, 6, 7, 5};
        int[] result = Testing.BubbleSort(apple);
        foreach (int n in result) {
            Console.WriteLine(n);
        }
        int[] result2 = TestingTwo.SelectionSort(apple);
        foreach (int n in result2) {
            Console.WriteLine(n);
        }
    }
}
