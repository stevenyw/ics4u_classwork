using System;

class Container {
    public string Brand;
    public string Color;
    private int _maxVolume;
    private int _volume;
    
    public Container(string brand, string color, int maxVolume) {
        this.Brand = brand;
        this.Color = color;
        this._maxVolume = maxVolume;
        this._volume = 0;
    }
    
    public virtual void Consume(int amount) {
        if (amount > this._volume) {
            throw new ArgumentException("You can't drink more than whats in the container");
        }
        this._volume -= amount;
    }
    public virtual void Fill(int amount) {
        if (amount > this._maxVolume - this._volume) {
            throw new ArgumentException("You can't fill more than what's in the container");
        }
        this._volume += amount;
    }
}

class SealableContainer : Container {
    protected bool _isSealed = true;
    
    public SealableContainer(string brand, string color, int maxVolume) : base(brand, color, maxVolume) {
    }
    
    public override void Consume(int amount) {
        if (this._isSealed == true) {
            throw new ArgumentException("You can't consume from a sealed off container");
        }
        base.Consume(amount);
    }
    public override void Fill(int amount) {
        if (this._isSealed == true) {
            throw new ArgumentException("You can't consume from a sealed off container");
        }
        base.Fill(amount);
    }
    
    public virtual void Open() {
        this._isSealed = false;
    }
    public virtual void Close() {
        this._isSealed = true;
    }
}

class LockableContainer : SealableContainer {
    protected bool _isLocked = true;
    
    public LockableContainer(string brand, string color, int maxVolume) : base(brand, color, maxVolume) {
    }
    public override void Consume(int amount) {
        if (this._isLocked == true) {
            throw new ArgumentException("You can't consume from a locked container");
        }
        base.Consume(amount);
    }
    public override void Fill(int amount) {
        if (this._isLocked == true) {
            throw new ArgumentException("You can't consume from a locked container");
        }
        base.Fill(amount);
    }
    public override void Open() {
        if (this._isLocked == true) {
            throw new ArgumentException("You can't open a locked container");
        }
        base.Open();
    }
    public override void Close() {
        if (this._isLocked == true) {
            throw new ArgumentException("You can't close a locked container");
        base.Close();
        }
    }
    public void Lock() {
        this._isLocked = true;
    }
    public void Unlock() {
        this._isLocked = false;
    }
} 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        LockableContainer lockingdevice = new LockableContainer("Lock-O-Tron 2000", "blue", 4757575);
        lockingdevice.Unlock();
        lockingdevice.Open();
        lockingdevice.Fill(444);
        lockingdevice.Consume(420);
    }
}
