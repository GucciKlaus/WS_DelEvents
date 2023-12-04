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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UCLib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UCUpDown : UserControl
    {
        // public event MyValueChangedDelegate? ValueChangedInformOthers;
        public EventHandler<MyEventArgs> ValueChangedInformOthers;
        private double _UCValue;

        public double UCValue
        {
            get { return _UCValue; }
            set {
                if (_UCValue == value) return;
                
                _UCValue = value;
                lblValue.Content = value.ToString();
                double delta = _UCValue - value;
                //Wenn sich jemand beim Delegate angemeldet hat, dann wird er mittels delegate / Event informiert
                ValueChangedInformOthers?.Invoke(this, new MyEventArgs { Value = _UCValue,Delta = delta,Description = "No Description"});
            }
        }

        public UCUpDown()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                Button? btnSender = sender as Button;
                if (Double.TryParse(btnSender?.Tag.ToString(),out double delta))
                {
                    UCValue += delta;
                }
            }
        }
        public void ValueChangedFromOutside(object sender, MyEventArgs args)
        {
            //UCValue = newValue;
            UCValue = args.Value;
            Console.WriteLine(args.Delta);
        }
    }
}