using System;

class Program {
    public static int[] SearchAllIn(int[] nums, int target) {
        int size = 0;
        foreach (int n in nums) {
            if (n == target) {
                size += 1;
            }
        }
        
        int[] foundLocations = new int[size];
        
        int cursor = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == target) {
                foundLocations[cursor] = i;
                cursor++;
            }
        }

        return foundLocations;
    }

    public static void Main(string[] args) {
        int[] marks = new int[] {89, 100, 89, 32, 100, 55, 100, 88};
        int[] locationsOf100 = SearchAllIn(marks, 100);
        
        foreach (int i in locationsOf100) {
            Console.WriteLine(i);
        }
    }
}
