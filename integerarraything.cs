using System;

class IntegerArrayList {
    private int[] _numbers;
    private int _cursor;
    
    public IntegerArrayList() {
        this._numbers = new int[5];
        this._cursor = 0;
    }
    
    public void Add(int n) {
        this._numbers[this._cursor] = n;
        this._cursor += 1;
    }
    
    public int Get(int n) {
        return this._numbers[n];
    }
    
    public string ToString(string str) {
        
        }
    }
    
}

class Program
{
    public static void Main(string[] args)
    {
    }
}
