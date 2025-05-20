using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] left = new int[] {4, 6, 6, 7};
        int[] right = new int[] {5, 6, 9, 10};
        int[] newarray = new int[left.Length + right.Length];
        int cursor = 0;
        int intleft = 0;
        int intright = 0;
        while (intleft < left.Length && intright < right.Length) {
            if (right[intright] < left[intleft]) {
                newarray[cursor] = right[intright];
                cursor += 1;
                intright += 1;
            } 
            if (right[intright] > left[intleft]) {
                newarray[cursor] = left[intleft];
                cursor += 1;
                intleft += 1;
            } else {
                newarray[cursor] = left[intleft];
                cursor += 1;
                intleft += 1;
            }
        }
            while (intleft < left.Length) {
            newarray[cursor] = left[intleft];
                cursor += 1;
                intleft += 1;
            }
            while (intright < right.Length) {
            newarray[cursor] = right[intright];
                cursor += 1;
                intright += 1;
            }
        foreach (int t in newarray) {
            Console.WriteLine(t);
        }
    }
}
