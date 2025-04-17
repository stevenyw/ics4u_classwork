using System;

class Testing {
    public static bool CommonEnd(int[] a, int[] b) {
        if (a[0] == b[0] || a[(a.Length-1)] == b[(b.Length-1)]) {
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
        int[] a = new int[] {1, 2, 3};
        int[] b = new int[] {1, 2, 3};
        bool apple = Testing.CommonEnd(a, b);
        Console.WriteLine(apple);
        }
    }
