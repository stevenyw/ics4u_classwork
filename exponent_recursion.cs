using System;

class Testing {
    public static int PowerN(int bases, int n) {
        if (n == 1) {
            return bases;
        }
        return bases * PowerN(bases, n-1);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int Test = Testing.PowerN(5, 2);
        Console.WriteLine(Test);
    }
}
