using System;

class Testing {
    public static int[] ArrayCombiner(int[] nums, int[] nums2) {
        int[] newnums = new int[nums.Length + nums2.Length];
        int cursor = 0;
        for (int i = 0; i < nums.Length; i++) {
            newnums[cursor] = nums[i];
            cursor += 1;
        }
        for (int i = 0; i < nums2.Length; i++) {
            newnums[cursor] = nums2[i];
            cursor += 1;
        }
        return newnums;
    }

    public static string ArrayToString(int[] newnums) {
        string thing = "";
        foreach (int i in newnums) {
            thing += i + ", ";
        }
        if (thing.Length > 0) {
            thing = thing.Substring(0, thing.Length-2); // Removes the last 2 characters
        }
        return "[" + thing + "]";
    }
}

class Program {
    public static void Main(string[] args) {
        int[] nums = new int[] {1, 2, 3, 4};
        int[] nums2 = new int[] {2, 3, 4, 5};
        int[] result = Testing.ArrayCombiner(nums, nums2);
        Console.WriteLine(Testing.ArrayToString(result));
    }
}
