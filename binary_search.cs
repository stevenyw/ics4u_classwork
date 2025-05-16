using System;

class Testing {
    public static int BinarySearch(int[] nums, int target) { // Remember!! binary search only works in a SORTED LIST!!!
        int left = nums[0];
        int right = nums[nums.Length - 1];
        int middle = (left+right) / 2;
        
        
        while (left < right) {
            if (nums[middle] == target) {
                return middle;
            }
            else if (nums[middle] > target) {
                right = middle-1; // move the right cursor to be less than the middle, since theres no way it can be greater than it
            }
            else {
                left = middle+1; // move the left cursor to be greater than the middle, since theres no way it can be less than it
            }
        }
        return -1;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
