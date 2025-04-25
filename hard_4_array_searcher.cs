using System;

class Testing {
    public static int[] Post4(int[] nums) {
        int cursor = 0;
        for (int i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] == 4) {
                cursor = i;
                break;
            }
        }
        int[] newarray = new int[nums.Length - cursor - 1];
        for (int i = 0; i < newarray.Length; i++) {
            newarray[i] = nums[cursor+i+1];
        }

        return newarray;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int[] nums2 = new int[] {3, 6, 3, 4, 1, 2};
        int[] result = Testing.Post4(nums2);
        foreach (int i in result) {
            Console.WriteLine("[" + i + "]");
            
        }
    }
}
