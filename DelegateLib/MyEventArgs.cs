using System;

namespace DelegateLib
{
    // public delegate void MyValueChangedDelegate(double val);
    public class MyEventArgs : EventArgs
    {
        public double Value { get; set; }
        public double Delta { get; set; }
        public String? Description { get; set; }
    }
}
