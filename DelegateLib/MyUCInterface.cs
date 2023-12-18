using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLib
{
    public interface MyUCInterface
    {
       MyModel UCModel { get; set; }
       public void ValueChangedFromOutside(object sender, MyEventArgs args);
    }
}
