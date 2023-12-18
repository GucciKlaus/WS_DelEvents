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
using UCLib;

namespace WS_DelEvents_5m
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //uc1.ValueChangedInformOthers += uc2.ValueChangedFromOutside;
            //uc1.ValueChangedInformOthers += uc3.ValueChangedFromOutside;

            //uc2.ValueChangedInformOthers += uc1.ValueChangedFromOutside;
            //uc2.ValueChangedInformOthers += uc3.ValueChangedFromOutside;

            //uc3.ValueChangedInformOthers += uc1.ValueChangedFromOutside;
            //uc3.ValueChangedInformOthers += uc2.ValueChangedFromOutside;
            //foreach (UIElement eventsenderElem in mainGrid.Children)
            //{
            //    if (eventsenderElem is UCUpDown)
            //    {
            //        foreach (UIElement eventReceiverElem in mainGrid.Children)
            //        {
            //            if (eventReceiverElem is UCUpDown && eventsenderElem != eventReceiverElem)
            //            {
            //                ((UCUpDown)eventsenderElem).ValueChangedInformOthers += ((UCUpDown)eventReceiverElem).ValueChangedFromOutside;
            //            }
            //        }
            //    }
            //}

            //Hier wird einmal das Model-Objekt erstellt und dann an alle MyUCInterface-Controls weitergegeben
            MyModel modelForAll = new MyModel();
            foreach (UIElement elem in mainGrid.Children)
            {
                //if (elem is UCUpDown)
                //{
                //    (elem as UCUpDown).UCModel = modelForAll;
                //    modelForAll.ValueChangedInformOthers += (elem as UCUpDown).ValueChangedFromOutside;
                //}
                if(elem is MyUCInterface)
                {
                    (elem as MyUCInterface).UCModel = modelForAll;
                    modelForAll.ValueChangedInformOthers += (elem as MyUCInterface).ValueChangedFromOutside;

                }


            }
        }
    }
}
