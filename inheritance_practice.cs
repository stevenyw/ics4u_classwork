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
        if (this._volume <= 0) {
            throw new ArgumentException("Container is empty");
        }
        this._volume -= amount;
    }
    
    public virtual void Fill(int amount) {
        if (this._volume >= this._maxVolume) {
            throw new ArgumentException("Container is full");
        }
        this._volume += amount;
    }
    
class SealableContainer : Container {
    private bool _isSealed = true;
        
    public SealableContainer(string brand, string color, int maxVolume) : base(brand, color, maxVolume) {
        }
        
    public override void Consume(int amount) {
        if (this._volume <= 0) {
            throw new ArgumentException("Container is empty");
            }
        base.Consume(amount);
        }
        
    public void Fill(int amount) {
        if (this._volume >= this._maxVolume) {
            throw new ArgumentException("Container is full"); }
        base.Fill(amount);
            }
        
    public void Open() {
        if (_isSealed == false) {
            throw new ArgumentException("It's already open");
        }
        _isSealed = false;
    }
    
    public void Closed() {
        if (_isSealed == true) {
            throw new ArgumentException("It's already closed");
        }
        _isSealed = true;
    }
}

class LockedContainer : SealableContainer {
    private bool _isLocked = false;
    
    public LockedContainer(string brand, string color, int maxVolume) : base(brand, color, maxVolume) {
    }
    
    // Make methods public
    public void Consume(int amount) {
        if (this._volume <= 0) {
            throw new ArgumentException("Container is empty");
            
        }
        if (amount > this._volume) {
            throw new ArgumentException("You can't drink more than the remaining volume");
            }
        if (_isLocked == true) {
            throw new ArgumentException("You can't consume from a locked container");
        }
        base.Consume(amount);
    }
        
    public void Fill(int amount) {
        if (this._volume >= this._maxVolume) {
            throw new ArgumentException("Container is full");
        }
        if (_isLocked == true) {
            throw new ArgumentException("You can't fill a locked container");
        }
        base.Fill(amount);
    }
    
    public void Open() {
       base.Open();
    }
    
    public void Closed() {
        base.Closed();
    }
    
    public void Lock() {
        _isLocked = true;
    }
    
    public void Unlock() {
        _isLocked = false;
    }
}

class Program {
    public static void Main(string[] args)
    {
        LockedContainer bucket = new LockedContainer("Michelin", "Black", 5);
        bucket.Fill(500);
        bucket.Consume(600);
    }
}
}
