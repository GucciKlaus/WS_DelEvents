using DelegateLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UCLib
{
    /// <summary>
    /// Interaction logic for Slideronly.xaml
    /// </summary>
    public partial class Slideronly : UserControl,MyUCInterface
    {
        public Slideronly()
        {
            InitializeComponent();
        }

        public MyModel UCModel { get; set; }
        

        private void SldValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UCModel.ModelValue = Math.Round(e.NewValue, 0);
        }

        public void ValueChangedFromOutside(object sender, MyEventArgs args)
        {
            if (UCModel != null)
            {
                sldValue.Value = args.Value;
            }
        }
    }
}
