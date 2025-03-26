using System;

class Computer {
    public string Screen;
    
    public Computer(string screen) {
        this.Screen = screen;
    }
}

class Projector {
    private Computer _input1;
    private Computer _input2;
    private int _activeInput;
    
    public Projector() {
        this._input1 = null;
        this._input2 = null;
        this._activeInput = 0;
    }
    
    public void ToggleActiveInput() {
        if (this._activeInput == 0) {
            this._activeInput = 1;
        } else {
            this._activeInput = 0;
        }
    }
    
    public void SetInput1(Computer input) {
        this._input1 = input;
    }
    
    public void SetInput2(Computer input) {
        this._input2 = input;
    }
    
    public string GetDisplay() {
            Computer activeComp;
            if (this._activeInput == 0) {
                activeComp = this._input1;
            } else {
                activeComp = this._input2;
            }
    
            if (activeComp != null)
                return activeComp.Screen;
            
            return "NO SIGNAL";
        }
}


class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine ("Yarn balls, I'm a n");
    }
}
