using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLib
{
    public class MyModel
    {
        private double _ModelValue;
        public EventHandler<MyEventArgs>? ValueChangedInformOthers;

        public double ModelValue
        {
            get { return _ModelValue; }
            set
            {
                _ModelValue = value;

                if (_ModelValue == value) return;
                double delta = _ModelValue - value;
                _ModelValue = value;
                //Wenn sich jemand beim Delegate angemeldet hat, dann wird er mittels delegate / Event informiert
                ValueChangedInformOthers?.Invoke(this, new MyEventArgs { Value = _ModelValue, Delta = delta, Description = "No Description" });
            }
        }
    }

}

